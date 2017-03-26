using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace lab3
{
    public partial class Relax : Form
    {
        public Relax()
        {
            InitializeComponent();
        }
        private Image source;
        private void loadButton_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "JPG|*.jpg;*.jpeg|PNG|*.png|BMP|*.bmp|GIF|*.gif|"
                + "All Graphics Types|*.bmp;*.jpg;*.jpeg;*.png";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            pictureSource.Image = Image.FromStream(myStream);
                            this.source = Image.FromStream(myStream);

                        }
                    }
                    ComputeDiagram();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void ComputeDiagram()
        {
            int[] rHist = new int[256];
            int[] gHist = new int[256];
            int[]bHist = new int[256];
            if (pictureSource.Image != null)
            {
                Bitmap sourceBitmap = (Bitmap)pictureSource.Image;
                BitmapData srcData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, sourceBitmap.PixelFormat);
                var size = ((Bitmap)this.pictureSource.Image).Size;
                int srcStride = srcData.Stride;
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(sourceBitmap.PixelFormat) / 8;
                int heightInPixels = srcData.Height;
                int widthInBytes = srcData.Width * bytesPerPixel;
                int stride = srcData.Stride;
                int allPixels = 0;
                unsafe
                {
                    byte* srcPointer = (byte*)srcData.Scan0;

                    for (int y = 0; y < heightInPixels; y++)
                    {
                        byte* currentLine = srcPointer + (y * stride);
                        for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                        {
                            Color color = Color.FromArgb(currentLine[x+2], currentLine[x + 1], currentLine[x]);
                            rHist[color.R]++;
                            gHist[color.G]++;
                            bHist[color.B]++;
                            allPixels++;
                        }
                    }
                }
                sourceBitmap.UnlockBits(srcData);
                int max = 0;
                for (int i = 0; i < 256; i++)
                {
                    if (rHist[i] > max)
                    {
                        max = rHist[i];
                    }
                    if (bHist[i] > max)
                    {
                        max = bHist[i];
                    }
                    if (gHist[i] > max)
                    {
                        max = gHist[i];
                    }
                }
                SetHist(this.hiR, avgR, allPixels, rHist, Color.Red, max);
                SetHist(this.hiG, avgG, allPixels, gHist, Color.Green, max);
                SetHist(this.hiB, avgB, allPixels, bHist, Color.Blue, max);
            }
        }

        private void SetHist(PictureBox box, Label avgLabel, int allPixels, int []histValues, Color color, int max)
        {
            double avg = 0;
            for (int i = 0; i < 256; i++)
            {
                avg += (histValues[i] * i);
            }
            avg = avg / allPixels;
            int hight = max > 100 ? 100 : max;
            double scale = hight / (double)max;
            avgLabel.Text = "Average: " + avg;
            Bitmap targetBitmap = new Bitmap(256, hight+1);
            for (int i = 0; i < targetBitmap.Size.Width; i++)
            {

                for (int j = 0; j < (int)histValues[i]*scale; j++)
                {
                    targetBitmap.SetPixel(i, hight-j, color);
                }
            }
            box.Image= targetBitmap;
        }
        byte GetNewBColor(int initialValue, int value)
        {
            value = value - 50;
            int plusV = value * 255 / 100;
            int result = initialValue + plusV;
            if (result > 255)
            {
                result = 255;
            }
            if (result < 0)
            {
                result = 0;
            }
            return (byte)result;
        }

        public void ChangeBrightness(int value)
        {
            if (pictureSource.Image != null)
            {
                Bitmap targetBitmap = (Bitmap)pictureSource.Image;
                Bitmap sourceBitmap = (Bitmap)(this.source);
                BitmapData srcData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, sourceBitmap.PixelFormat);
                BitmapData trgData = targetBitmap.LockBits(new Rectangle(0, 0, targetBitmap.Width, targetBitmap.Height), ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
                var size = ((Bitmap)this.pictureSource.Image).Size;
                int srcStride = srcData.Stride;
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(sourceBitmap.PixelFormat) / 8;
                int heightInPixels = srcData.Height;
                int widthInBytes = srcData.Width * bytesPerPixel;
                int stride = srcData.Stride;
                unsafe
                {
                    byte* trgPointer = (byte*)trgData.Scan0;
                    byte* srcPointer = (byte*)srcData.Scan0;

                    for (int y = 0; y < heightInPixels; y++)
                    {
                        byte* currentLine = srcPointer + (y * stride);
                        byte* currentTarget = trgPointer + (y * stride);
                        for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                        {
                            currentTarget[x] = GetNewBColor(currentLine[x], value);
                            currentTarget[x + 1] = GetNewBColor(currentLine[x + 1], value);
                            currentTarget[x + 2] = GetNewBColor(currentLine[x + 2], value);
                        }
                    }
                }
                targetBitmap.UnlockBits(trgData);
                sourceBitmap.UnlockBits(srcData);
                this.pictureSource.Image = targetBitmap;
            }
        }

        private void bBar_Scroll(object sender, EventArgs e)
        {
            ChangeBrightness(this.bBar.Value);
            ComputeDiagram();
        }

        public void ChangeContrast(int value)
        {
            int lab = 0;
            int allPixels = 0;
            if (pictureSource.Image != null)
            {
                Bitmap sourceBitmap = (Bitmap)pictureSource.Image;
                BitmapData srcData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, sourceBitmap.PixelFormat);
                var size = ((Bitmap)this.pictureSource.Image).Size;
                int srcStride = srcData.Stride;
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(sourceBitmap.PixelFormat) / 8;
                int heightInPixels = srcData.Height;
                int widthInBytes = srcData.Width * bytesPerPixel;
                int stride = srcData.Stride;
                unsafe
                {
                    byte* srcPointer = (byte*)srcData.Scan0;

                    for (int y = 0; y < heightInPixels; y++)
                    {
                        byte* currentLine = srcPointer + (y * stride);
                        for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                        {
                            Color color = Color.FromArgb(currentLine[x + 2], currentLine[x + 1], currentLine[x]);
                            lab += (int)(color.R * 0.299 + color.G * 0.587 + color.B * 0.114);
                            allPixels++;
                        }
                    }
                }
                sourceBitmap.UnlockBits(srcData);
            }
            lab = lab / allPixels;
            double k = 1.0 + value / 100.0;
            int[] nColors = new int[256];
            for (int i = 0; i < 256; i++)
            {
                int delta = (int)i - lab;
                int temp = (int)(lab + k * delta);

                if (temp < 0)
                    temp = 0;

                if (temp >= 255)
                    temp = 255;
                nColors[i] = temp;
            }

            if (pictureSource.Image != null)
            {
                Bitmap targetBitmap = (Bitmap)pictureSource.Image;
                Bitmap sourceBitmap = (Bitmap)(this.source);
                BitmapData srcData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadOnly, sourceBitmap.PixelFormat);
                BitmapData trgData = targetBitmap.LockBits(new Rectangle(0, 0, targetBitmap.Width, targetBitmap.Height), ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
                var size = ((Bitmap)this.pictureSource.Image).Size;
                int srcStride = srcData.Stride;
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(sourceBitmap.PixelFormat) / 8;
                int heightInPixels = srcData.Height;
                int widthInBytes = srcData.Width * bytesPerPixel;
                int stride = srcData.Stride;
                unsafe
                {
                    byte* trgPointer = (byte*)trgData.Scan0;
                    byte* srcPointer = (byte*)srcData.Scan0;

                    for (int y = 0; y < heightInPixels; y++)
                    {
                        byte* currentLine = srcPointer + (y * stride);
                        byte* currentTarget = trgPointer + (y * stride);
                        for (int x = 0; x < widthInBytes; x = x + bytesPerPixel)
                        {
                            currentTarget[x] = (byte)nColors[currentLine[x]];
                            currentTarget[x + 1] = (byte)nColors[currentLine[x + 1]];
                            currentTarget[x + 2] = (byte)nColors[currentLine[x + 2]];
                        }
                    }
                }
                targetBitmap.UnlockBits(trgData);
                sourceBitmap.UnlockBits(srcData);
                this.pictureSource.Image = targetBitmap;
            }
        }
        private void cBar_Scroll(object sender, EventArgs e)
        {
            ChangeContrast(this.cBar.Value);
            ComputeDiagram();
        }
    }
}
