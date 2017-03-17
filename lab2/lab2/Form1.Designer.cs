namespace lab2
{
    partial class Relax
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.sourcePicture = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.targetPicture = new System.Windows.Forms.PictureBox();
            this.sourceNumericR = new System.Windows.Forms.NumericUpDown();
            this.sourceBarR = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sourceBarG = new System.Windows.Forms.TrackBar();
            this.sourceNumericG = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.sourceBarB = new System.Windows.Forms.TrackBar();
            this.sourceNumericB = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.targetBarR = new System.Windows.Forms.TrackBar();
            this.targetNumericR = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.targetBarG = new System.Windows.Forms.TrackBar();
            this.targetNumericG = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.targetBarB = new System.Windows.Forms.TrackBar();
            this.targetNumericB = new System.Windows.Forms.NumericUpDown();
            this.sourceSample = new System.Windows.Forms.PictureBox();
            this.targetSample = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.senBarL = new System.Windows.Forms.TrackBar();
            this.senNumericL = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.senBarA = new System.Windows.Forms.TrackBar();
            this.senNumericA = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.senBarB = new System.Windows.Forms.TrackBar();
            this.senNumericB = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.senBarSen = new System.Windows.Forms.TrackBar();
            this.senNumericSen = new System.Windows.Forms.NumericUpDown();
            this.applyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceNumericR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceNumericG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceNumericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumericR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBarG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumericG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetSample)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senBarL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senNumericL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senBarA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senNumericA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senBarB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senNumericB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senBarSen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.senNumericSen)).BeginInit();
            this.SuspendLayout();
            // 
            // sourcePicture
            // 
            this.sourcePicture.BackColor = System.Drawing.Color.White;
            this.sourcePicture.Location = new System.Drawing.Point(25, 45);
            this.sourcePicture.Name = "sourcePicture";
            this.sourcePicture.Size = new System.Drawing.Size(404, 271);
            this.sourcePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourcePicture.TabIndex = 0;
            this.sourcePicture.TabStop = false;
            this.sourcePicture.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sourcePicture_MouseClick);
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(27, 8);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(75, 23);
            this.loadButton.TabIndex = 2;
            this.loadButton.Text = "Load image";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // targetPicture
            // 
            this.targetPicture.BackColor = System.Drawing.Color.White;
            this.targetPicture.Location = new System.Drawing.Point(464, 45);
            this.targetPicture.Name = "targetPicture";
            this.targetPicture.Size = new System.Drawing.Size(404, 271);
            this.targetPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.targetPicture.TabIndex = 3;
            this.targetPicture.TabStop = false;
            // 
            // sourceNumericR
            // 
            this.sourceNumericR.Location = new System.Drawing.Point(58, 370);
            this.sourceNumericR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sourceNumericR.Name = "sourceNumericR";
            this.sourceNumericR.Size = new System.Drawing.Size(44, 20);
            this.sourceNumericR.TabIndex = 1;
            this.sourceNumericR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sourceNumericR.ValueChanged += new System.EventHandler(this.sourceNumericR_ValueChanged);
            // 
            // sourceBarR
            // 
            this.sourceBarR.LargeChange = 1;
            this.sourceBarR.Location = new System.Drawing.Point(111, 361);
            this.sourceBarR.Maximum = 255;
            this.sourceBarR.Name = "sourceBarR";
            this.sourceBarR.Size = new System.Drawing.Size(318, 45);
            this.sourceBarR.TabIndex = 1;
            this.sourceBarR.Value = 255;
            this.sourceBarR.ValueChanged += new System.EventHandler(this.sourceBarR_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 372);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "G";
            // 
            // sourceBarG
            // 
            this.sourceBarG.LargeChange = 1;
            this.sourceBarG.Location = new System.Drawing.Point(111, 412);
            this.sourceBarG.Maximum = 255;
            this.sourceBarG.Name = "sourceBarG";
            this.sourceBarG.Size = new System.Drawing.Size(318, 45);
            this.sourceBarG.TabIndex = 6;
            this.sourceBarG.Value = 255;
            this.sourceBarG.ValueChanged += new System.EventHandler(this.sourceBarG_ValueChanged);
            // 
            // sourceNumericG
            // 
            this.sourceNumericG.Location = new System.Drawing.Point(58, 421);
            this.sourceNumericG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sourceNumericG.Name = "sourceNumericG";
            this.sourceNumericG.Size = new System.Drawing.Size(44, 20);
            this.sourceNumericG.TabIndex = 5;
            this.sourceNumericG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sourceNumericG.ValueChanged += new System.EventHandler(this.sourceNumericG_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 474);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "B";
            // 
            // sourceBarB
            // 
            this.sourceBarB.LargeChange = 1;
            this.sourceBarB.Location = new System.Drawing.Point(111, 463);
            this.sourceBarB.Maximum = 255;
            this.sourceBarB.Name = "sourceBarB";
            this.sourceBarB.Size = new System.Drawing.Size(318, 45);
            this.sourceBarB.TabIndex = 9;
            this.sourceBarB.Value = 255;
            this.sourceBarB.ValueChanged += new System.EventHandler(this.sourceBarB_ValueChanged);
            // 
            // sourceNumericB
            // 
            this.sourceNumericB.Location = new System.Drawing.Point(58, 472);
            this.sourceNumericB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sourceNumericB.Name = "sourceNumericB";
            this.sourceNumericB.Size = new System.Drawing.Size(44, 20);
            this.sourceNumericB.TabIndex = 8;
            this.sourceNumericB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.sourceNumericB.ValueChanged += new System.EventHandler(this.sourceNumericB_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(458, 372);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "R";
            // 
            // targetBarR
            // 
            this.targetBarR.LargeChange = 1;
            this.targetBarR.Location = new System.Drawing.Point(547, 361);
            this.targetBarR.Maximum = 255;
            this.targetBarR.Name = "targetBarR";
            this.targetBarR.Size = new System.Drawing.Size(318, 45);
            this.targetBarR.TabIndex = 12;
            this.targetBarR.Value = 255;
            this.targetBarR.ValueChanged += new System.EventHandler(this.targetBarR_ValueChanged);
            // 
            // targetNumericR
            // 
            this.targetNumericR.Location = new System.Drawing.Point(494, 370);
            this.targetNumericR.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.targetNumericR.Name = "targetNumericR";
            this.targetNumericR.Size = new System.Drawing.Size(44, 20);
            this.targetNumericR.TabIndex = 11;
            this.targetNumericR.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.targetNumericR.ValueChanged += new System.EventHandler(this.targetNumericR_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(461, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "G";
            // 
            // targetBarG
            // 
            this.targetBarG.LargeChange = 1;
            this.targetBarG.Location = new System.Drawing.Point(550, 412);
            this.targetBarG.Maximum = 255;
            this.targetBarG.Name = "targetBarG";
            this.targetBarG.Size = new System.Drawing.Size(318, 45);
            this.targetBarG.TabIndex = 15;
            this.targetBarG.Value = 255;
            this.targetBarG.ValueChanged += new System.EventHandler(this.targetBarG_ValueChanged);
            // 
            // targetNumericG
            // 
            this.targetNumericG.Location = new System.Drawing.Point(497, 421);
            this.targetNumericG.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.targetNumericG.Name = "targetNumericG";
            this.targetNumericG.Size = new System.Drawing.Size(44, 20);
            this.targetNumericG.TabIndex = 14;
            this.targetNumericG.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.targetNumericG.ValueChanged += new System.EventHandler(this.targetNumericG_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(458, 474);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "B";
            // 
            // targetBarB
            // 
            this.targetBarB.LargeChange = 1;
            this.targetBarB.Location = new System.Drawing.Point(547, 463);
            this.targetBarB.Maximum = 255;
            this.targetBarB.Name = "targetBarB";
            this.targetBarB.Size = new System.Drawing.Size(318, 45);
            this.targetBarB.TabIndex = 18;
            this.targetBarB.Value = 255;
            this.targetBarB.ValueChanged += new System.EventHandler(this.targetBarB_ValueChanged);
            // 
            // targetNumericB
            // 
            this.targetNumericB.Location = new System.Drawing.Point(494, 472);
            this.targetNumericB.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.targetNumericB.Name = "targetNumericB";
            this.targetNumericB.Size = new System.Drawing.Size(44, 20);
            this.targetNumericB.TabIndex = 17;
            this.targetNumericB.Value = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.targetNumericB.ValueChanged += new System.EventHandler(this.targetNumericB_ValueChanged);
            // 
            // sourceSample
            // 
            this.sourceSample.BackColor = System.Drawing.Color.White;
            this.sourceSample.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sourceSample.Location = new System.Drawing.Point(162, 339);
            this.sourceSample.Name = "sourceSample";
            this.sourceSample.Size = new System.Drawing.Size(100, 20);
            this.sourceSample.TabIndex = 20;
            this.sourceSample.TabStop = false;
            // 
            // targetSample
            // 
            this.targetSample.BackColor = System.Drawing.Color.White;
            this.targetSample.Location = new System.Drawing.Point(667, 339);
            this.targetSample.Name = "targetSample";
            this.targetSample.Size = new System.Drawing.Size(100, 20);
            this.targetSample.TabIndex = 21;
            this.targetSample.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(877, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "L";
            // 
            // senBarL
            // 
            this.senBarL.LargeChange = 1;
            this.senBarL.Location = new System.Drawing.Point(966, 45);
            this.senBarL.Maximum = 100;
            this.senBarL.Name = "senBarL";
            this.senBarL.Size = new System.Drawing.Size(236, 45);
            this.senBarL.TabIndex = 23;
            this.senBarL.Value = 100;
            this.senBarL.ValueChanged += new System.EventHandler(this.senBarL_ValueChanged);
            // 
            // senNumericL
            // 
            this.senNumericL.Location = new System.Drawing.Point(913, 54);
            this.senNumericL.Name = "senNumericL";
            this.senNumericL.Size = new System.Drawing.Size(44, 20);
            this.senNumericL.TabIndex = 22;
            this.senNumericL.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.senNumericL.ValueChanged += new System.EventHandler(this.senNumericL_ValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(877, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(13, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "a";
            // 
            // senBarA
            // 
            this.senBarA.LargeChange = 1;
            this.senBarA.Location = new System.Drawing.Point(966, 96);
            this.senBarA.Maximum = 100;
            this.senBarA.Name = "senBarA";
            this.senBarA.Size = new System.Drawing.Size(236, 45);
            this.senBarA.TabIndex = 26;
            this.senBarA.Value = 100;
            this.senBarA.ValueChanged += new System.EventHandler(this.senBarA_ValueChanged);
            // 
            // senNumericA
            // 
            this.senNumericA.Location = new System.Drawing.Point(913, 105);
            this.senNumericA.Name = "senNumericA";
            this.senNumericA.Size = new System.Drawing.Size(44, 20);
            this.senNumericA.TabIndex = 25;
            this.senNumericA.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.senNumericA.ValueChanged += new System.EventHandler(this.senNumericA_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(877, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "b";
            // 
            // senBarB
            // 
            this.senBarB.LargeChange = 1;
            this.senBarB.Location = new System.Drawing.Point(966, 147);
            this.senBarB.Maximum = 100;
            this.senBarB.Name = "senBarB";
            this.senBarB.Size = new System.Drawing.Size(236, 45);
            this.senBarB.TabIndex = 29;
            this.senBarB.Value = 100;
            this.senBarB.ValueChanged += new System.EventHandler(this.senBarB_ValueChanged);
            // 
            // senNumericB
            // 
            this.senNumericB.Location = new System.Drawing.Point(913, 156);
            this.senNumericB.Name = "senNumericB";
            this.senNumericB.Size = new System.Drawing.Size(44, 20);
            this.senNumericB.TabIndex = 28;
            this.senNumericB.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.senNumericB.ValueChanged += new System.EventHandler(this.senNumericB_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(877, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(26, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Sen";
            // 
            // senBarSen
            // 
            this.senBarSen.LargeChange = 1;
            this.senBarSen.Location = new System.Drawing.Point(966, 194);
            this.senBarSen.Maximum = 100;
            this.senBarSen.Name = "senBarSen";
            this.senBarSen.Size = new System.Drawing.Size(236, 45);
            this.senBarSen.TabIndex = 32;
            this.senBarSen.Value = 100;
            this.senBarSen.ValueChanged += new System.EventHandler(this.senBarSen_ValueChanged);
            // 
            // senNumericSen
            // 
            this.senNumericSen.Location = new System.Drawing.Point(913, 203);
            this.senNumericSen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.senNumericSen.Name = "senNumericSen";
            this.senNumericSen.Size = new System.Drawing.Size(44, 20);
            this.senNumericSen.TabIndex = 31;
            this.senNumericSen.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.senNumericSen.ValueChanged += new System.EventHandler(this.senNumericSen_ValueChanged);
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(966, 316);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(177, 43);
            this.applyButton.TabIndex = 34;
            this.applyButton.Text = "Apply Weights";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // Relax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1209, 543);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.senBarSen);
            this.Controls.Add(this.senNumericSen);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.senBarB);
            this.Controls.Add(this.senNumericB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.senBarA);
            this.Controls.Add(this.senNumericA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.senBarL);
            this.Controls.Add(this.senNumericL);
            this.Controls.Add(this.targetSample);
            this.Controls.Add(this.sourceSample);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.targetBarB);
            this.Controls.Add(this.targetNumericB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.targetBarG);
            this.Controls.Add(this.targetNumericG);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.targetBarR);
            this.Controls.Add(this.targetNumericR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sourceBarB);
            this.Controls.Add(this.sourceNumericB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.sourceBarG);
            this.Controls.Add(this.sourceNumericG);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sourceBarR);
            this.Controls.Add(this.sourceNumericR);
            this.Controls.Add(this.targetPicture);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.sourcePicture);
            this.Name = "Relax";
            this.Text = "Relax";
            ((System.ComponentModel.ISupportInitialize)(this.sourcePicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceNumericR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceNumericG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceNumericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumericR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBarG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumericG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetNumericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.targetSample)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senBarL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senNumericL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senBarA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senNumericA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senBarB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senNumericB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senBarSen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.senNumericSen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox sourcePicture;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.PictureBox targetPicture;
        private System.Windows.Forms.NumericUpDown sourceNumericR;
        private System.Windows.Forms.TrackBar sourceBarR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar sourceBarG;
        private System.Windows.Forms.NumericUpDown sourceNumericG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TrackBar sourceBarB;
        private System.Windows.Forms.NumericUpDown sourceNumericB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar targetBarR;
        private System.Windows.Forms.NumericUpDown targetNumericR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TrackBar targetBarG;
        private System.Windows.Forms.NumericUpDown targetNumericG;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar targetBarB;
        private System.Windows.Forms.NumericUpDown targetNumericB;
        private System.Windows.Forms.PictureBox sourceSample;
        private System.Windows.Forms.PictureBox targetSample;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TrackBar senBarL;
        private System.Windows.Forms.NumericUpDown senNumericL;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TrackBar senBarA;
        private System.Windows.Forms.NumericUpDown senNumericA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TrackBar senBarB;
        private System.Windows.Forms.NumericUpDown senNumericB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TrackBar senBarSen;
        private System.Windows.Forms.NumericUpDown senNumericSen;
        private System.Windows.Forms.Button applyButton;
    }
}

