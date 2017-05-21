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
        private const string Erosion = "Erosion";
        private const string Dilation = "Dilation";
        private const string Opening = "Opening";
        private const string Closing = "Closing";
        public Relax()
        {
            InitializeComponent();
            operationUpDown.Items.Add(Erosion);
            operationUpDown.Items.Add(Dilation);
            operationUpDown.Items.Add(Opening);
            operationUpDown.Items.Add(Closing);
            operationUpDown.SelectedIndex = 0;
        }
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
                            pictureInit.Image = Image.FromStream(myStream);

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }


        public void ChangeContrast()
        {
            if (pictureSource.Image == null || pictureInit.Image == null || cBar.Value == 0)
            {
                if (cBar.Value == 0 && pictureInit.Image != null)
                {
                    pictureSource.Image = (Image)pictureInit.Image.Clone();
                }
                return;
            }
            int power = cBar.Value;
            int size = power * 2 + 1;
            int[,] kernel = new int[size, size];
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    kernel[i, j] = -1;
                }
            }
            kernel[power, power] = size * size;
            if (pictureSource.Image != null)
            {
                unsafe
                {
                    Bitmap sourceBitmap = (Bitmap)pictureInit.Image;
                    Bitmap targetBitmap = (Bitmap)pictureSource.Image;
                    BitmapData bitmapData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
                    BitmapData bitmapDataTarget = targetBitmap.LockBits(new Rectangle(0, 0, targetBitmap.Width, targetBitmap.Height), ImageLockMode.ReadWrite, targetBitmap.PixelFormat);
                    int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(sourceBitmap.PixelFormat) / 8;
                    int heightInPixels = bitmapData.Height;
                    int widthInBytes = bitmapData.Width * bytesPerPixel;
                    byte* ptrFirstPixelSource = (byte*)bitmapData.Scan0;
                    byte* ptrFirstPixelTarget = (byte*)bitmapDataTarget.Scan0;
                    int kernelWidth = kernel.GetLength(0);
                    int kernelHeight = kernel.GetLength(1);
                    for (int x = 0; x < sourceBitmap.Width; x++)
                    {
                        for (int y = 0; y < sourceBitmap.Height; y++)
                        {
                            double rSum = 0, gSum = 0, bSum = 0, kSum = 0;

                            for (int i = 0; i < kernelWidth; i++)
                            {
                                for (int j = 0; j < kernelHeight; j++)
                                {
                                    int pixelPosX = x + (i - (kernelWidth / 2));
                                    int pixelPosY = y + (j - (kernelHeight / 2));
                                    if ((pixelPosX < 0) ||
                                      (pixelPosX >= sourceBitmap.Width) ||
                                      (pixelPosY < 0) ||
                                      (pixelPosY >= sourceBitmap.Height)) continue;
                                    byte* currentLine = ptrFirstPixelSource + (pixelPosY * bitmapData.Stride);
                                    int x_arr = pixelPosX * bytesPerPixel;
                                    byte r = currentLine[x_arr + 2];
                                    byte g = currentLine[x_arr + 1];
                                    byte b = currentLine[x_arr];

                                    double kernelVal = kernel[i, j];

                                    rSum += r * kernelVal;
                                    gSum += g * kernelVal;
                                    bSum += b * kernelVal;

                                    kSum += kernelVal;
                                }
                            }

                            if (kSum <= 0) kSum = 1;

                            rSum /= kSum;
                            if (rSum < 0) rSum = 0;
                            if (rSum > 255) rSum = 255;

                            gSum /= kSum;
                            if (gSum < 0) gSum = 0;
                            if (gSum > 255) gSum = 255;

                            bSum /= kSum;
                            if (bSum < 0) bSum = 0;
                            if (bSum > 255) bSum = 255;
                            byte* currentLineT = ptrFirstPixelTarget + (y * bitmapData.Stride);
                            int x_arrT = x * bytesPerPixel;
                            currentLineT[x_arrT] = (byte)bSum;
                            currentLineT[x_arrT + 1] = (byte)gSum;
                            currentLineT[x_arrT + 2] = (byte)rSum;
                        }
                    }
                    sourceBitmap.UnlockBits(bitmapData);
                    targetBitmap.UnlockBits(bitmapDataTarget);
                    this.pictureSource.Image = targetBitmap;
                    Console.WriteLine("Done");
                }
            }

        }

        public void DoBinary()
        {
            if (pictureSource.Image == null || pictureInit.Image == null)
            {
                return;
            }
            if (pictureSource.Image != null)
            {
                unsafe
                {
                    Bitmap sourceBitmap = (Bitmap)pictureInit.Image;
                    Bitmap targetBitmap = (Bitmap)pictureSource.Image;
                    BitmapData bitmapData = sourceBitmap.LockBits(new Rectangle(0, 0, sourceBitmap.Width, sourceBitmap.Height), ImageLockMode.ReadWrite, sourceBitmap.PixelFormat);
                    BitmapData bitmapDataTarget = targetBitmap.LockBits(new Rectangle(0, 0, targetBitmap.Width, targetBitmap.Height), ImageLockMode.ReadWrite, targetBitmap.PixelFormat);
                    int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(sourceBitmap.PixelFormat) / 8;
                    int heightInPixels = bitmapData.Height;
                    int widthInBytes = bitmapData.Width * bytesPerPixel;
                    byte* ptrFirstPixelSource = (byte*)bitmapData.Scan0;
                    byte* ptrFirstPixelTarget = (byte*)bitmapDataTarget.Scan0;
                    bool[,] out_result = new bool[sourceBitmap.Width, sourceBitmap.Height];
                    for (int x = 0; x < sourceBitmap.Width; x++)
                    {
                        for (int y = 0; y < sourceBitmap.Height; y++)
                        {
                            byte* currentLine_o = ptrFirstPixelSource + (y * bitmapData.Stride);
                            int x_arr_o = x * bytesPerPixel;
                            byte r_o = currentLine_o[x_arr_o + 2];
                            byte g_o = currentLine_o[x_arr_o + 1];
                            byte b_o = currentLine_o[x_arr_o];
                            //structure start 0,0
                            if (r_o != 255 || g_o != 255 || b_o != 255)
                            {
                                out_result[x, y] = true;
                                continue;
                            }
                            else
                            {
                                out_result[x, y] = false;
                            }
                           
                        }
                    }
                    for (int x = 0; x < sourceBitmap.Width; x++)
                    {
                        for (int y = 0; y < sourceBitmap.Height; y++)
                        {
                            byte* currentLineT = ptrFirstPixelTarget + (y * bitmapData.Stride);
                            int x_arrT = x * bytesPerPixel;
                            int result = out_result[x, y] ? 0 : 255;
                            currentLineT[x_arrT] = (byte)result;
                            currentLineT[x_arrT + 1] = (byte)result;
                            currentLineT[x_arrT + 2] = (byte)result;
                            byte* currentLine_s = ptrFirstPixelSource + (y * bitmapData.Stride);
                            int x_arr_s = x * bytesPerPixel;
                            currentLine_s[x_arr_s + 2] = (byte)result;
                            currentLine_s[x_arr_s + 1] = (byte)result;
                            currentLine_s[x_arr_s] = (byte)result;
                        }
                    }
                    sourceBitmap.UnlockBits(bitmapData);
                    targetBitmap.UnlockBits(bitmapDataTarget);
                    this.pictureSource.Image = targetBitmap;
                    Console.WriteLine("Done");
                }
            }
        }
        public bool[,] fill_in_result(Image image)
        {
            bool[,] out_result = new bool[image.Width, image.Height];
            unsafe
            {
                Bitmap targetBitmap = (Bitmap)image;
                BitmapData bitmapData = targetBitmap.LockBits(new Rectangle(0, 0, targetBitmap.Width, targetBitmap.Height), ImageLockMode.ReadWrite, targetBitmap.PixelFormat);
              
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(targetBitmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* ptrFirstPixel= (byte*)bitmapData.Scan0;
                for (int x = 0; x < targetBitmap.Width; x++)
                {
                    for (int y = 0; y < targetBitmap.Height; y++)
                    {
                        byte* currentLine_o = ptrFirstPixel + (y * bitmapData.Stride);
                        int x_arr_o = x * bytesPerPixel;
                        byte r_o = currentLine_o[x_arr_o + 2];
                        byte g_o = currentLine_o[x_arr_o + 1];
                        byte b_o = currentLine_o[x_arr_o];
                        //structure start 0,0
                        out_result[x,y] = r_o == 0 && g_o == 0 && b_o == 0;
                    }
                }
                targetBitmap.UnlockBits(bitmapData);
            }
            return out_result;
        }
        public void applyIn_in_result(PictureBox box, bool[,] out_result)
        {
            unsafe
            {
                Bitmap targetBitmap = (Bitmap)box.Image;
                BitmapData bitmapData = targetBitmap.LockBits(new Rectangle(0, 0, targetBitmap.Width, targetBitmap.Height), ImageLockMode.ReadWrite, targetBitmap.PixelFormat);
              
                int bytesPerPixel = System.Drawing.Bitmap.GetPixelFormatSize(targetBitmap.PixelFormat) / 8;
                int heightInPixels = bitmapData.Height;
                int widthInBytes = bitmapData.Width * bytesPerPixel;
                byte* ptrFirstPixelTarget = (byte*)bitmapData.Scan0;
                for (int x = 0; x < targetBitmap.Width; x++)
                {
                    for (int y = 0; y < targetBitmap.Height; y++)
                    {
                        byte* currentLineT = ptrFirstPixelTarget + (y * bitmapData.Stride);
                        int x_arrT = x * bytesPerPixel;
                        int result = out_result[x, y] ? 0 : 255;
                        currentLineT[x_arrT] = (byte)result;
                        currentLineT[x_arrT + 1] = (byte)result;
                        currentLineT[x_arrT + 2] = (byte)result;
                    }
                }
                targetBitmap.UnlockBits(bitmapData);
                box.Image = targetBitmap;
            }
        }
        public bool[,]  ChangeBinaryDilation(bool[,] in_result)
        {
            int structureW = (int)this.widthUpDown.Value;
            int structureH = (int)this.heightUpDown.Value;
            int[,] kernel = new int[structureW, structureH];
            for (int i = 0; i < structureW; i++)
            {
                for (int j = 0; j < structureH; j++)
                {
                    kernel[i, j] = 1;
                }
            }
            int xWidth = in_result.GetLength(0);
            int xHeight = in_result.GetLength(1);
            int kernelWidth = kernel.GetLength(0);
            int kernelHeight = kernel.GetLength(1);
            bool[,] out_result = new bool[xWidth, xHeight];
            for (int x = 0; x < xWidth; x++)
            {
                for (int y = 0; y < xHeight; y++)
                {
                    if (!in_result[x, y])
                    {
                        continue;
                    }
                    for (int i = 0; i < kernelWidth; i++)
                    {
                        for (int j = 0; j < kernelHeight; j++)
                        {
                            int pixelPosX = x + i;
                            int pixelPosY = y + j;
                            if ((pixelPosX < 0) ||
                              (pixelPosX >= xWidth) ||
                              (pixelPosY < 0) ||
                              (pixelPosY >= xHeight)) continue;
                            bool is_s = in_result[pixelPosX, pixelPosY];
                            bool is_k = kernel[i, j] == 1;
                            out_result[pixelPosX, pixelPosY] = is_k || is_s;
                        }
                    }
                }
            }
            return out_result;
        }

        public bool[,] ChangeBinaryErosion(bool[,] in_result)
        {
            int structureW = (int)this.widthUpDown.Value;
            int structureH = (int)this.heightUpDown.Value;
            int[,] kernel = new int[structureW, structureH];
            int number_of_black = structureW * structureH;
            for (int i = 0; i < structureW; i++)
            {
                for (int j = 0; j < structureH; j++)
                {
                    kernel[i, j] = 1;
                }
            }
            int xWidth = in_result.GetLength(0);
            int xHeight = in_result.GetLength(1);
            int kernelWidth = kernel.GetLength(0);
            int kernelHeight = kernel.GetLength(1);
            bool[,] out_result = new bool[xWidth, xHeight];
            for (int x = 0; x < xWidth; x++)
            {
                for (int y = 0; y < xHeight; y++)
                {
                    if (!in_result[x, y])
                    {
                        continue;
                    }
                    int k = 0;
                    for (int i = 0; i < kernelWidth; i++)
                    {
                        for (int j = 0; j < kernelHeight; j++)
                        {
                            int pixelPosX = x + i;
                            int pixelPosY = y + j;
                            if ((pixelPosX < 0) ||
                              (pixelPosX >= xWidth) ||
                              (pixelPosY < 0) ||
                              (pixelPosY >= xHeight))
                            {
                                k++; continue;
                            }
                            bool is_s = in_result[pixelPosX, pixelPosY];
                            bool is_k = kernel[i, j] == 1;
                            if (is_k && is_s)
                            {
                                k++;
                            }

                        }
                    }
                    for (int i = 0; i < kernelWidth; i++)
                    {
                        for (int j = 0; j < kernelHeight; j++)
                        {
                            int pixelPosX = x + i;
                            int pixelPosY = y + j;
                            if ((pixelPosX < 0) ||
                              (pixelPosX >= xWidth) ||
                              (pixelPosY < 0) ||
                              (pixelPosY >= xHeight)) { continue; }
                            out_result[pixelPosX, pixelPosY] = k == number_of_black;
                        }

                    }

                }
            }
            return out_result;
        }

        private void cBar_Scroll(object sender, EventArgs e)
        {
            ChangeContrast();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            if (pictureInit.Image == null)
            {
                return;
            }
            bool[,] in_result = fill_in_result(pictureInit.Image);
            bool[,] out_result = null;
            switch (operationUpDown.Text)
            {
                case Erosion:
                    out_result = ChangeBinaryErosion(in_result);
                    break;
                case Dilation:
                    out_result = ChangeBinaryDilation(in_result);
                    break;
                case Opening:
                    out_result = ChangeBinaryErosion(in_result);
                    out_result = ChangeBinaryDilation(out_result);
                    break;
                case Closing:
                    out_result = ChangeBinaryDilation(in_result);

                    out_result = ChangeBinaryErosion(out_result);
                    break;
            };
            applyIn_in_result(this.pictureSource, out_result);
        }

        private void button1_Click(object sender, EventArgs e)
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
                            pictureInit.Image = Image.FromStream(myStream);

                        }
                    }
                    DoBinary();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
    }
}
