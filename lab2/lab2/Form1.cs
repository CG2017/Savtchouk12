﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace lab2
{
    public partial class Relax : Form
    {

        private const int RGB_Value = 255;
        private const int LAB_L_Value = 100;
        private const int LAB_AB_Value = 128;
        private int[] sourceLAB = new int[3];
        private static double[,] RGB_XYZ = { {0.4887180,  0.3106803 , 0.2006017},
                                           {0.1762044 , 0.8129847,  0.0108109},
                                           {0.0000000,  0.0102048,  0.9897952}};
        private static double[,] XYZ_RGB = { {2.3706743, -0.9000405, -0.4706338},
                                           {-0.5138850,  1.4253036,  0.0885814},
                                           {0.0052982, -0.0146949,  1.0093968}};
        private const double WP = 1 / 3.0;
        private const double e = 0.008856;
        private const double k = 903.3;
        private Func<double, double> F = (s) => { return s < e ? (k * s + 16) / 116.0 : Math.Pow(s, 1 / 3.0); };
        public Relax()
        {
            InitializeComponent();
        }

        private void sourceNumericR_ValueChanged(object sender, EventArgs e)
        {
            this.sourceBarR.Value = (int)this.sourceNumericR.Value;
            SetSourceColor();
        }

        private void sourceNumericG_ValueChanged(object sender, EventArgs e)
        {
            this.sourceBarG.Value = (int)this.sourceNumericG.Value;
            SetSourceColor();
        }

        private void sourceNumericB_ValueChanged(object sender, EventArgs e)
        {
            this.sourceBarB.Value = (int)this.sourceNumericB.Value;
            SetSourceColor();
        }

        private void sourceBarR_ValueChanged(object sender, EventArgs e)
        {
            this.sourceNumericR.Value = this.sourceBarR.Value;
            SetSourceColor();
        }

        private void sourceBarG_ValueChanged(object sender, EventArgs e)
        {
            this.sourceNumericG.Value = this.sourceBarG.Value;
            SetSourceColor();
        }

        private void sourceBarB_ValueChanged(object sender, EventArgs e)
        {
            this.sourceNumericB.Value = this.sourceBarB.Value;
            SetSourceColor();
        }

        private void targetNumericR_ValueChanged(object sender, EventArgs e)
        {
            this.targetBarR.Value = (int)this.targetNumericR.Value;
            SetTargetColor();
        }

        private void targetNumericG_ValueChanged(object sender, EventArgs e)
        {
            this.targetBarG.Value = (int)this.targetNumericG.Value;
            SetTargetColor();
        }

        private void targetNumericB_ValueChanged(object sender, EventArgs e)
        {
            this.targetBarB.Value = (int)this.targetNumericB.Value;
            SetTargetColor();
        }

        private void targetBarR_ValueChanged(object sender, EventArgs e)
        {
            this.targetNumericR.Value = this.targetBarR.Value;
            SetTargetColor();
        }

        private void targetBarG_ValueChanged(object sender, EventArgs e)
        {
            this.targetNumericG.Value = this.targetBarG.Value;
            SetTargetColor();
        }

        private void targetBarB_ValueChanged(object sender, EventArgs e)
        {
            this.targetNumericB.Value = this.targetBarB.Value;
            SetTargetColor();
        }

        private void senNumericL_ValueChanged(object sender, EventArgs e)
        {
            this.senBarL.Value = (int)this.senNumericL.Value;
        }

        private void senNumericA_ValueChanged(object sender, EventArgs e)
        {
            this.senBarA.Value = (int)this.senNumericA.Value;
        }

        private void senNumericB_ValueChanged(object sender, EventArgs e)
        {
            this.senBarB.Value = (int)this.senNumericB.Value;
        }

        private void senNumericSen_ValueChanged(object sender, EventArgs e)
        {
            this.senBarSen.Value = (int)this.senNumericSen.Value;
        }

        private void senBarL_ValueChanged(object sender, EventArgs e)
        {
            this.senNumericL.Value = this.senBarL.Value;
        }

        private void senBarA_ValueChanged(object sender, EventArgs e)
        {
            this.senNumericA.Value = this.senBarA.Value;
        }

        private void senBarB_ValueChanged(object sender, EventArgs e)
        {
            this.senNumericB.Value = this.senBarB.Value;
        }

        private void senBarSen_ValueChanged(object sender, EventArgs e)
        {
            this.senNumericSen.Value = this.senBarSen.Value;
        }

        private void SetTargetColor()
        {
            Color color = Color.FromArgb(targetBarR.Value, targetBarG.Value, targetBarB.Value);
            this.targetSample.BackColor = color;
            //ChangePixels();
        }

        private void SetSourceColor()
        {
            Color color = Color.FromArgb(sourceBarR.Value, sourceBarG.Value, sourceBarB.Value);
            this.sourceSample.BackColor = color;
            //ChangePixels();
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
                            sourcePicture.Image = Image.FromStream(myStream);                            
                        }
                    }
                    Bitmap targetBitmap = new Bitmap(this.sourcePicture.Image.Width, this.sourcePicture.Image.Height);
                    targetPicture.Image = targetBitmap;
                    //ChangePixels();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void sourcePicture_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Color pixelColor;
                if (this.sourcePicture.Image != null)
                {
                    int coordX = e.Location.X * this.sourcePicture.Image.Width / this.sourcePicture.Width;
                    int coordY = e.Location.Y * this.sourcePicture.Image.Height / this.sourcePicture.Height;
                    pixelColor = ((Bitmap)this.sourcePicture.Image).GetPixel(coordX, coordY);
                }
                else
                {
                    pixelColor = this.sourcePicture.BackColor;
                }
                this.sourceSample.BackColor = pixelColor;
                this.sourceNumericR.Value = pixelColor.R;
                this.sourceNumericG.Value = pixelColor.G;
                this.sourceNumericB.Value = pixelColor.B;
            }
        }

        private double[] RGBFromXYZ(double[] XYZ)
        {
            double[] RGB = new double[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    RGB[i] += XYZ[j] * XYZ_RGB[i, j];
                }
            }
            for (int i = 0; i < 3; i++)
            {
                RGB[i] = RGB[i] * RGB_Value;
            }
            return RGB;
        }

        private int[] RGBFromLAB(int[] LAB)
        {
            double[] Lab = { LAB[0], LAB[1], LAB[2] };
            double fy = (Lab[0] + 16) / 116;
            double fx = Lab[1] / 500 + fy;
            double fz = fy - Lab[2] / 200;
            double[] XYZ = new double[3];
            XYZ[0] = (Math.Pow(fx, 3) > e ? Math.Pow(fx, 3) : (116 * fx - 16) / k) * WP;
            XYZ[1] = (Lab[0] > e * k ? Math.Pow((Lab[0] + 16) / 116, 3) : Lab[0] / k) * WP;
            XYZ[2] = (Math.Pow(fz, 3) > e ? Math.Pow(fz, 3) : (116 * fz - 16) / k) * WP;
            for (int i = 0; i < XYZ.Length; i++)
            {
                XYZ[i] = Math.Round(XYZ[i] * 100) / 100.0;
            }
            double[] RGB = RGBFromXYZ(XYZ);
            int R = (int)RGB[0];
            int G = (int)RGB[1];
            int B = (int)RGB[2];
            R = (R < 0 ? 0 : (R > 255 ? 255 : R));
            G = (G < 0 ? 0 : (G > 255 ? 255 : G));
            B = (B < 0 ? 0 : (B > 255 ? 255 : B));
            return new int[] { R, G, B };
        }

        private double[] XYZFromRGB(int[] RGB_init)
        {
            double[] RGB = {RGB_init[0] / (double)RGB_Value, RGB_init[1] / (double)RGB_Value, RGB_init[2] / (double)RGB_Value };
            double[] XYZ = new double[3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    XYZ[i] += RGB[j] * RGB_XYZ[i, j];
                }
            }
            for (int i = 0; i < XYZ.Length; i++)
            {
                XYZ[i] = Math.Round(XYZ[i] * 100) / 100.0;
            }
            return XYZ;
        }

        private int [] GetLabFromRGB(int[] RGB)
        {
            double[] XYZ = XYZFromRGB(RGB);
            for (int i = 0; i < 3; i++)
            {
                XYZ[i] = XYZ[i] / (WP);
            }
            int L = (int)(116 * F(XYZ[1]) - 16);
            int A = (int)(500 * (F(XYZ[0]) - F(XYZ[1])));
            int B = (int)(200 * (F(XYZ[1]) - F(XYZ[2])));
           // L = L < 0 ? 0 : (L > LAB_L_Value ? LAB_L_Value : L);
           // A = A < -LAB_AB_Value ? -LAB_AB_Value : (A > LAB_AB_Value ? LAB_AB_Value : A);
           // B = B < -LAB_AB_Value ? -LAB_AB_Value : (B > LAB_AB_Value ? LAB_AB_Value : B);
            int[] Lab = new int[3]{L, A, B};
            return Lab;
        }

        private int[] GetSourceTargetDifference()
        {
            int[] diff = new int[3];
            this.sourceLAB = GetLabFromRGB(new int[] { sourceBarR.Value, sourceBarG.Value, sourceBarB.Value });
            
            int[] targetLab = GetLabFromRGB(new int[] { targetBarR.Value, targetBarG.Value, targetBarB.Value });
            diff[0] = targetLab[0] - this.sourceLAB[0];
            diff[1] = targetLab[1] - this.sourceLAB[1];
            diff[2] = targetLab[2] - this.sourceLAB[2];
            return diff;
        }

        private bool ShouldUpdate(int[] sourceColor, int[] diff)
        {
            var Lw = this.senBarL.Value/100.0;
            var La = this.senBarA.Value/100.0;
            var Lb = this.senBarB.Value/100.0;
            var sen = this.senBarSen.Value;
            var dist = Math.Sqrt(Lw*Math.Pow(this.sourceLAB[0] - sourceColor[0], 2.0) + La*Math.Pow(this.sourceLAB[1] - sourceColor[1], 2.0) + Lb*Math.Pow(this.sourceLAB[2] - sourceColor[2], 2.0));
            return dist < sen;
        }

        private void ChangePixels()
        {
            var diff = GetSourceTargetDifference();
            if (this.sourcePicture.Image!=null)
            {
                Bitmap targetBitmap = new Bitmap(this.sourcePicture.Image.Width, this.sourcePicture.Image.Height);
                var size = ((Bitmap)this.sourcePicture.Image).Size;
                for (int i = 0; i < size.Width; i++)
                {
                    for (int j = 0; j < size.Height; j++)
                    {
                        var sourceColor = ((Bitmap)this.sourcePicture.Image).GetPixel(i, j);
                        Color color = sourceColor;
                        var sourceLab = GetLabFromRGB(new int[] { sourceColor.R, sourceColor.G, sourceColor.B });
                        if (ShouldUpdate(sourceLab, diff))
                        {
                            var targetLab = new int[] { sourceLab[0] += diff[0], sourceLab[1] += diff[1], sourceLab[2] += diff[2] };
                            var targetRGB = RGBFromLAB(targetLab);
                            color = Color.FromArgb(targetRGB[0], targetRGB[1], targetRGB[2]);
                        }
                        targetBitmap.SetPixel(i, j, color);
                    }
                }
                targetPicture.Image = targetBitmap;
            }
        }

        private void applyButton_Click(object sender, EventArgs e)
        {
            ChangePixels();
        }
    }
}
