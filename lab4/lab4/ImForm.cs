using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace lab4
{
    public partial class ImForm : Form
    {
        public class Tuple<K, T>
        {
            public K Item1 { get; set; }
            public T Item2 { get; set; }

        }
        public class ImageRow
        {
            public int Index { get; set; }
            public string FileName { get; set; }
            public String Size { get; set; }
            public string Resolution { get; set; }
            public string Compression { get; set; }
            public ImageRow(int idx, Image image, string fileName)
            {
                Index = idx;
                if (image != null)
                {
                    FileName = fileName;
                    Size = image.Width + " x "+image.Height;
                    Resolution = image.HorizontalResolution + " x " + image.VerticalResolution;
                    Compression = GetCompressionType(image);
                }

            }

            private static string GetCompressionType(Image image)
            {
                int compressionIdx = Array.IndexOf(image.PropertyIdList, 0x0103);
                int compressionType = 0;
                string compression = "Unknown compression";
                if (compressionIdx != -1)
                {
                    PropertyItem compressionTag = image.PropertyItems[compressionIdx];
                    compressionType = BitConverter.ToInt16(compressionTag.Value, 0);
                }
                else
                {
                    compression = "No compression";
                }
                switch (compressionType)
                {
                    case 1:
                        compression = "No compression";
                        break;
                    case 2:
                        compression = "CCITT Huffman";
                        break;
                    case 3:
                        compression = "CCITT Group 3";
                        break;
                    case 4:
                        compression = "CCITT Group 4";
                        break;
                    case 5:
                        compression = "LZW";
                        break;
                    case 6:
                        compression = "Old style JPEG";
                        break;
                    case 7:
                        compression = "New style JPEG";
                        break;
                    case 8:
                        compression = "Flate";
                        break;
                }
                return compression;
            }
        }
        private BackgroundWorker bWorker;
        private BindingList<ImageRow> rows;
        private List<Image> rowsImg;
        public ImForm()
        {
            InitializeComponent();
            rows = new BindingList<ImageRow>();
            rowsImg = new List<Image>();
            bWorker = new BackgroundWorker();
            bWorker.DoWork += new DoWorkEventHandler(ProcessImages);
            bWorker.ProgressChanged += new ProgressChangedEventHandler
                    (PublishProgress);
            bWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler
                    (ProcessingCompleted);
            bWorker.WorkerReportsProgress = true;
            this.ImageTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            this.ImageTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.ImageTable.MultiSelect = false;
            this.ImageTable.ReadOnly = true;
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            openFileDialog.InitialDirectory = "c:\\";
            openFileDialog.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|BMP|*.bmp|GIF|*.gif|"
                + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png;*.gif;*.tif";
            openFileDialog.FilterIndex = 5;
            openFileDialog.RestoreDirectory = true;
            openFileDialog.Multiselect = true;


            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.openButton.Enabled = false;
                    this.button2.Enabled = false;
                    bWorker.RunWorkerAsync(openFileDialog);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void ProcessImages(object sender, DoWorkEventArgs e)
        {
            OpenFileDialog openFileDialog = (OpenFileDialog)e.Argument;
            int filesProcessed = 0;

            List<Tuple<ImageRow, Image>> imRows = new List<Tuple<ImageRow, Image>>();
            double allLength = openFileDialog.FileNames.Length;
            foreach (string filename in openFileDialog.FileNames)
            {
                filesProcessed++;
                int progress = (int)((filesProcessed / allLength)*100);
                bWorker.ReportProgress(progress);
                Image image = Image.FromFile(filename);
                ImageRow row = new ImageRow(rows.Count + filesProcessed, image, filename);
                Tuple<ImageRow, Image> t = new Tuple<ImageRow, Image>();
                t.Item1 = row;
                t.Item2 = image;
                imRows.Add(t);
            }
            e.Result = imRows;
        }

        private void PublishProgress(object sender, ProgressChangedEventArgs e)
        {
            progressLabel.Text = "Processing......" + e.ProgressPercentage +"%";
        }

        private void ProcessingCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            List<Tuple<ImageRow, Image>> imRows = (List<Tuple<ImageRow, Image>>)e.Result;
            foreach (var im in imRows)
            {
                rows.Add(im.Item1);
                rowsImg.Add(im.Item2);
            }
            progressLabel.Text = "Processing finished";
            var source = new BindingSource(rows, null);
            this.ImageTable.DataSource = source;
            this.openButton.Enabled = true;
            this.button2.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rows.Clear();
            rowsImg.Clear();
            this.pictureView.Image = null;
        }

        private void ImageTable_SelectionChanged(object sender, EventArgs e)
        {
            if (ImageTable.SelectedRows.Count > 0 && this.rowsImg.Count > 0)
            {
                //this.progressLabel.Text = "Row selected " + ImageTable.SelectedRows[0].Index.ToString();
                this.pictureView.Image = this.rowsImg[ImageTable.SelectedRows[0].Index];
            }
        }
    }
}
