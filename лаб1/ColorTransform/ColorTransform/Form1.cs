using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ColorTransform
{
    public partial class ColorForm : Form
    {
        private const int CMY_RGB_Value = 255;
        private const int HSV_H_Value = 360;
        private const int HSV_SV_LAB_L_Value = 100;
        private const int LAB_AB_Value = 128;
        private static double[,] RGB_XYZ = { {0.4887180,  0.3106803 , 0.2006017},
                                           {0.1762044 , 0.8129847,  0.0108109},
                                           {0.0000000,  0.0102048,  0.9897952}};
        private static double[,] XYZ_RGB = { {2.3706743, -0.9000405, -0.4706338},
                                           {-0.5138850,  1.4253036,  0.0885814},
                                           {0.0052982, -0.0146949,  1.0093968}};
        private const double WP = 1/3.0;
        private const double e = 0.008856;
        private const double k = 903.3;
        private Func<double, double> F = (s) => { return s < e ? (k * s + 16) / 116.0 : Math.Pow(s, 1/3.0); };
        private bool recalculateRGB = true;
        private bool recalculateCMY = true;
        private bool recalculateHSV = true;
        private bool recalculateLAB = true;

        public ColorForm()
        {
            InitializeComponent();
            AllFromRGB();
        }

        private void colorButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorPicker.ShowDialog();
            if (result.Equals(DialogResult.OK))
            {
                SetColorValues(colorPicker.Color);
            }
        }


        private void rgbBarR_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateRGB)
            {
                recalculateRGB = false;
                RGBNormalize();
                AllFromRGB();
            }
        }

        private void rgbBarG_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateRGB)
            {
                recalculateRGB = false;
                RGBNormalize();
                AllFromRGB();
            }
        }

        private void rgbBarB_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateRGB)
            {
                recalculateRGB = false;
                RGBNormalize();
                AllFromRGB();
            }
        }

        private void rgbNumericR_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateRGB)
            {
                recalculateRGB = false;
                rgbBarR.Value = (int)rgbNumericR.Value;
                AllFromRGB();
            }
        }

        private void rgbNumericG_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateRGB)
            {
                recalculateRGB = false;
                rgbBarG.Value = (int)rgbNumericG.Value;
                AllFromRGB();
            }
        }

        private void rgbNumericB_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateRGB)
            {
                recalculateRGB = false;
                rgbBarB.Value = (int)rgbNumericB.Value;
                AllFromRGB();
            }
        }

        private void cmyBarC_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateCMY)
            {
                recalculateCMY = false;
                CMYNormalize();
                AllFromCMY();
            }
        }

        private void cmyBarM_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateCMY)
            {
                recalculateCMY = false;
                CMYNormalize();
                AllFromCMY();
            }
        }

        private void cmyBarY_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateCMY)
            {
                recalculateCMY = false;
                CMYNormalize();
                AllFromCMY();
            }
        }

        private void cmyNumericC_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateCMY)
            {
                recalculateCMY = false;
                cmyBarC.Value = (int)cmyNumericC.Value;
                AllFromCMY();
            }
        }

        private void cmyNumericM_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateCMY)
            {
                recalculateCMY = false;
                cmyBarM.Value = (int)cmyNumericM.Value;
                AllFromCMY();
            }
        }

        private void cmyNumericY_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateCMY)
            {
                recalculateCMY = false;
                cmyBarY.Value = (int)cmyNumericY.Value;
                AllFromCMY();
            }
        }

        private void hsvBarH_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateHSV)
            {
                recalculateHSV = false;
                HSVNormalize();
                AllFromHSV();
            }
        }

        private void hsvBarS_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateHSV)
            {
                recalculateHSV = false;
                HSVNormalize();
                AllFromHSV();
            }
        }

        private void hsvBarV_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateHSV)
            {
                recalculateHSV = false;
                HSVNormalize();
                AllFromHSV();
            }
        }

        private void hsvNumericH_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateHSV)
            {
                recalculateHSV = false;
                hsvBarH.Value = (int)hsvNumericH.Value;
                AllFromHSV();
            }
        }

        private void hsvNumericS_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateHSV)
            {
                recalculateHSV = false;
                hsvBarS.Value = (int)hsvNumericS.Value;
                AllFromHSV();
            }
        }

        private void hsvNumericV_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateHSV)
            {
                recalculateHSV = false;
                hsvBarV.Value = (int)hsvNumericV.Value;
                AllFromHSV();
            }
        }

        private void labBarL_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateLAB)
            {
                recalculateLAB = false;
                LABNormalize();
                AllFromLAB();
            }
        }

        private void labBarA_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateLAB)
            {
                recalculateLAB = false;
                LABNormalize();
                AllFromLAB();
            }
        }

        private void labBarB_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateLAB)
            {
                recalculateLAB = false;
                LABNormalize();
                AllFromLAB();
            }
        }

        private void labNumericL_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateLAB)
            {
                recalculateLAB = false;
                labBarL.Value = (int)labNumericL.Value;
                AllFromLAB();
            }
        }

        private void labNumericA_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateLAB)
            {
                recalculateLAB = false;
                labBarA.Value = (int)labNumericA.Value;
                AllFromLAB();
            }
        }

        private void labNumericB_ValueChanged(object sender, EventArgs e)
        {
            if (recalculateLAB)
            {
                recalculateLAB = false;
                labBarB.Value = (int)labNumericB.Value;
                AllFromLAB();
            }
        }

        private void SetColorValues(Color color)
        {
            colorButton.BackColor = color;
            recalculateRGB = false;
            rgbBarR.Value = color.R;
            rgbBarG.Value = color.G;
            rgbBarB.Value = color.B;
            rgbNumericR.Value = (int)rgbBarR.Value;
            rgbNumericG.Value = (int)rgbBarG.Value;
            rgbNumericB.Value = (int)rgbBarB.Value;
            recalculateRGB = true;
            AllFromRGB();
        }

        private void AllFromCMY()
        {
            recalculateRGB = false;
            recalculateCMY = false;
            recalculateHSV = false;
            recalculateLAB = false;
            RGBFromCMY();
            HSVFromRGB();
            LABFromRGB();
            recalculateRGB = true;
            recalculateCMY = true;
            recalculateHSV = true;
            recalculateLAB = true;
            SetDialogColor();
            markCMY(cmyBarC.Value, cmyBarM.Value, cmyBarY.Value);
        }

        private void AllFromRGB()
        {
            recalculateRGB = false;
            recalculateCMY = false;
            recalculateHSV = false;
            recalculateLAB = false;
            CMYFromRGB();
            HSVFromRGB();
            LABFromRGB();
            recalculateRGB = true;
            recalculateCMY = true;
            recalculateHSV = true;
            recalculateLAB = true;
            SetDialogColor();
            markRGB(rgbBarR.Value, rgbBarG.Value, rgbBarB.Value);
        }

        private void AllFromHSV()
        {
            recalculateRGB = false;
            recalculateCMY = false;
            recalculateHSV = false;
            recalculateLAB = false;
            RGBFromHSV();
            CMYFromRGB();
            LABFromRGB();
            recalculateRGB = true;
            recalculateCMY = true;
            recalculateHSV = true;
            recalculateLAB = true;
            SetDialogColor();
            markHSV(hsvBarH.Value, hsvBarS.Value, hsvBarV.Value);
        }

        private void AllFromLAB()
        {
            recalculateRGB = false;
            recalculateCMY = false;
            recalculateHSV = false;
            recalculateLAB = false;
            RGBFromLAB();
            CMYFromRGB();
            HSVFromRGB();
            recalculateRGB = true;
            recalculateCMY = true;
            recalculateHSV = true;
            recalculateLAB = true;
            SetDialogColor();
            markLAB(labBarL.Value, labBarA.Value, labBarB.Value);
        }

        private void CMYFromRGB()
        {
            int C = CMY_RGB_Value - rgbBarR.Value;
            int M = CMY_RGB_Value - rgbBarG.Value;
            int Y = CMY_RGB_Value - rgbBarB.Value;
            markCMY(C, M, Y);
            C = C < 0 ? 0 : (C > CMY_RGB_Value ? CMY_RGB_Value : C);
            M = M < 0 ? 0 : (M > CMY_RGB_Value ? CMY_RGB_Value : M);
            Y = Y < 0 ? 0 : (Y > CMY_RGB_Value ? CMY_RGB_Value : Y);
            cmyBarC.Value = C;
            cmyBarM.Value = M;
            cmyBarY.Value = Y;
            cmyNumericC.Value = (int)cmyBarC.Value;
            cmyNumericM.Value = (int)cmyBarM.Value;
            cmyNumericY.Value = (int)cmyBarY.Value;
        }

        private void RGBFromCMY()
        {
            int R = CMY_RGB_Value - cmyBarC.Value;
            int G = CMY_RGB_Value - cmyBarM.Value;
            int B = CMY_RGB_Value - cmyBarY.Value;
            markRGB(R, G, B);
            R = R < 0 ? 0 : (R > CMY_RGB_Value ? CMY_RGB_Value : R);
            G = G < 0 ? 0 : (G > CMY_RGB_Value ? CMY_RGB_Value : G);
            B = B < 0 ? 0 : (B > CMY_RGB_Value ? CMY_RGB_Value : B);
            rgbBarR.Value = R;
            rgbBarG.Value = G;
            rgbBarB.Value = B;
            rgbNumericR.Value = (int)rgbBarR.Value;
            rgbNumericG.Value = (int)rgbBarG.Value;
            rgbNumericB.Value = (int)rgbBarB.Value;
        }

        private void RGBFromHSV()
        {
            int H = hsvBarH.Value;
            int S = hsvBarS.Value;
            int V = hsvBarV.Value;
            double R = 0, G = 0, B = 0;
            if (S == 0)
            {
                R = (int)(V * 255.0 / 100);
                G = (int)(V * 255.0 / 100);
                B = (int)(V * 255.0 / 100);
            }
            else
            {
                var sector = ((int)Math.Floor(H / 60.0)) % 6;
                var frac = H / 60.0 - sector;
                var T = V * (1 - S / 100.0);
                var P = V * (1 - S * frac / 100);
                var Q = V * (1 - (S / 100.0) * (1 - frac));

                switch (sector)
                {
                    case 0: R = V; G = Q; B = T; break;
                    case 1: R = P; G = V; B = T; break;
                    case 2: R = T; G = V; B = Q; break;
                    case 3: R = T; G = P; B = V; break;
                    case 4: R = Q; G = T; B = V; break;
                    case 5: R = V; G = T; B = P; break;
                }
            }
            R = (int)(R * 255 / 100.0);
            G = (int)(G * 255 / 100.0);
            B = (int)(B * 255 / 100.0);
            markRGB((int)R, (int)G, (int)B);
            R = (R < 0 ? 0 : (R > 255 ? 255 : R));
            G = (G < 0 ? 0 : (G > 255 ? 255 : G));
            B = (B < 0 ? 0 : (B > 255 ? 255 : B));
            rgbBarR.Value = (int)R;
            rgbBarG.Value = (int)G;
            rgbBarB.Value = (int)B;
            rgbNumericR.Value = (int)rgbBarR.Value;
            rgbNumericG.Value = (int)rgbBarG.Value;
            rgbNumericB.Value = (int)rgbBarB.Value;
        }

        private void HSVFromRGB()
        {
            int R = rgbBarR.Value;
            int G = rgbBarG.Value;
            int B = rgbBarB.Value;
            double H = 0, S = 0, V = 0;
            var maxVal = (double)Math.Max(G, Math.Max(R, B));
            var minVal = (double)Math.Min(G, Math.Min(R, B));
            V = maxVal;

            if (maxVal == 0)
                S = 0;
            else
                S = (maxVal - minVal) / maxVal;
            if (S == 0)
                H = 0;
            else
            {
                if (R == maxVal)
                    H = (G - B) / (maxVal - minVal);
                else if (G == maxVal)
                    H = 2 + (B - R) / (maxVal - minVal);
                else if (B == maxVal)
                    H = 4 + (R - G) / (maxVal - minVal);
                H = H * 60;
                if (H < 0)
                    H = H + 360;
            }
            V = (int)(V * 100.0 / 255.0);
            S = S * 100;
            markHSV((int)H, (int)S, (int)V);
            H = H < 0 ? 0 : (H > HSV_H_Value? HSV_H_Value : H);
            S = S < 0 ? 0 : (S > HSV_SV_LAB_L_Value ? HSV_SV_LAB_L_Value : S);
            V = V < 0 ? 0 : (V > HSV_SV_LAB_L_Value ? HSV_SV_LAB_L_Value: V);
            hsvBarH.Value = (int)H;
            hsvBarV.Value = (int)V;
            hsvBarS.Value = (int)S;
            hsvNumericH.Value = (int)hsvBarH.Value;
            hsvNumericS.Value = (int)hsvBarS.Value;
            hsvNumericV.Value = (int)hsvBarV.Value;

        }

        private void LABFromRGB()
        {
            double[] XYZ = XYZFromRGB();
            for (int i = 0; i < 3; i++)
            {
                XYZ[i] = XYZ[i] / (WP);
            }
            int L = (int)(116 * F(XYZ[1]) - 16);
            int A = (int)(500 * (F(XYZ[0]) - F(XYZ[1])));
            int B = (int)(200 * (F(XYZ[1]) - F(XYZ[2])));
            markLAB(L, A, B);
            L = L < 0 ? 0 : (L > HSV_SV_LAB_L_Value ? HSV_SV_LAB_L_Value : L);
            A = A < -LAB_AB_Value ? -LAB_AB_Value : (A > LAB_AB_Value ? LAB_AB_Value : A);
            B = B < -LAB_AB_Value ? -LAB_AB_Value : (B > LAB_AB_Value ? LAB_AB_Value : B);
            labBarL.Value = (int)L;
            labBarA.Value = (int)A;
            labBarB.Value = (int)B;
            labNumericL.Value = (int)labBarL.Value;
            labNumericA.Value = (int)labBarA.Value;
            labNumericB.Value = (int)labBarB.Value;
        }

        private void RGBFromLAB()
        {
            double[] Lab = { labBarL.Value, labBarA.Value, labBarB.Value };
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
            markRGB(R, G, B);
            R = (R < 0 ? 0 : (R > 255 ? 255 : R));
            G = (G < 0 ? 0 : (G > 255 ? 255 : G));
            B = (B < 0 ? 0 : (B > 255 ? 255 : B));
            rgbBarR.Value = R;
            rgbBarG.Value = G;
            rgbBarB.Value = B;
            rgbNumericR.Value = (int)rgbBarR.Value;
            rgbNumericG.Value = (int)rgbBarG.Value;
            rgbNumericB.Value = (int)rgbBarB.Value;
        }

        private double[] XYZFromRGB()
        {
            double[] RGB = { rgbBarR.Value / (double)CMY_RGB_Value, rgbBarG.Value / (double)CMY_RGB_Value, rgbBarB.Value / (double)CMY_RGB_Value };
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
                XYZ[i] = Math.Round(XYZ[i] * 100)/100.0;
            }
            return XYZ;
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
                RGB[i] = RGB[i] * CMY_RGB_Value;
            }
            return RGB;
        }

        private void RGBNormalize()
        {
            rgbNumericR.Value = rgbBarR.Value;
            rgbNumericG.Value = rgbBarG.Value;
            rgbNumericB.Value = rgbBarB.Value;
        }

        private void CMYNormalize()
        {
            cmyNumericC.Value = cmyBarC.Value;
            cmyNumericM.Value = cmyBarM.Value;
            cmyNumericY.Value = cmyBarY.Value;
        }

        private void HSVNormalize()
        {
            hsvNumericH.Value = hsvBarH.Value;
            hsvNumericS.Value = hsvBarS.Value;
            hsvNumericV.Value = hsvBarV.Value;
        }

        private void LABNormalize()
        {
            labNumericL.Value = labBarL.Value;
            labNumericA.Value = labBarA.Value;
            labNumericB.Value = labBarB.Value;
        }

        private void SetDialogColor()
        {
            var color = Color.FromArgb(rgbBarR.Value, rgbBarG.Value, rgbBarB.Value);
            colorPicker.Color = color;
            colorButton.BackColor = color;
        }

        public void markRGB(int R, int G, int B)
        {
            if (R < 0 || R > CMY_RGB_Value)
            {
                rgbErrorR.SetError(rgbBarR, "Out of range " + R);
            }
            else
            {
                rgbErrorR.Clear();
            }

            if (G < 0 || G > CMY_RGB_Value)
            {
                rgbErrorG.SetError(rgbBarG, "Out of range " + G);
            }
            else
            {
                rgbErrorG.Clear();
            }
            if (B < 0 || B > CMY_RGB_Value)
            {
                rgbErrorB.SetError(rgbBarB, "Out of range " + B);
            }
            else
            {
                rgbErrorB.Clear();
            }
        }

        public void markCMY(int C, int M, int Y)
        {
            if (C < 0 || C > CMY_RGB_Value)
            {
                cmyErrorC.SetError(cmyBarC, "Out of range " + C);
            }
            else
            {
                cmyErrorC.Clear();
            }
            if (M < 0 || M > CMY_RGB_Value)
            {
                cmyErrorM.SetError(cmyBarM, "Out of range " + M);
            }
            else
            {
                cmyErrorM.Clear();
            }
            if (Y < 0 || Y > CMY_RGB_Value)
            {
                cmyErrorY.SetError(cmyBarY, "Out of range " + Y);
            }
            else
            {
                cmyErrorY.Clear();
            }
        }

        public void markHSV(int H, int S, int V)
        {
            if (H < 0 || H > HSV_H_Value)
            {
                hsvErrorH.SetError(hsvBarH, "Out of range " + H);
            }
            else
            {
                hsvErrorH.Clear();
            }

            if (S < 0 || S > HSV_SV_LAB_L_Value)
            {
                hsvErrorS.SetError(hsvBarS, "Out of range " + S);
            }
            else
            {
                hsvErrorS.Clear();
            }

            if (V < 0 || V > HSV_SV_LAB_L_Value)
            {
                hsvErrorV.SetError(hsvBarV, "Out of range " + V);
            }
            else
            {
                hsvErrorV.Clear();
            }
        }

        public void markLAB(int L, int A, int B)
        {
            if (L < 0 || L > HSV_SV_LAB_L_Value)
            {
                labErrorL.SetError(labBarL, "Out of range " + L);
            }
            else
            {
                labErrorL.Clear();
            }
            if (A < -LAB_AB_Value || A > LAB_AB_Value)
            {
                labErrorA.SetError(labBarA, "Out of range " + A);
            }
            else
            {
                labErrorA.Clear();
            }
            if (B < -LAB_AB_Value || B > LAB_AB_Value)
            {
                labErrorB.SetError(labBarB, "Out of range " + B);
            }
            else
            {
                labErrorB.Clear();
            }
        }
    }
}
