namespace lab3
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
            this.pictureSource = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.avgR = new System.Windows.Forms.Label();
            this.cBar = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureInit = new System.Windows.Forms.PictureBox();
            this.widthUpDown = new System.Windows.Forms.NumericUpDown();
            this.heightUpDown = new System.Windows.Forms.NumericUpDown();
            this.operationUpDown = new System.Windows.Forms.DomainUpDown();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSource
            // 
            this.pictureSource.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureSource.Location = new System.Drawing.Point(465, 85);
            this.pictureSource.Name = "pictureSource";
            this.pictureSource.Size = new System.Drawing.Size(400, 320);
            this.pictureSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSource.TabIndex = 0;
            this.pictureSource.TabStop = false;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(33, 23);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(132, 23);
            this.loadButton.TabIndex = 5;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.loadButton_Click);
            // 
            // avgR
            // 
            this.avgR.AutoSize = true;
            this.avgR.Location = new System.Drawing.Point(502, 156);
            this.avgR.Name = "avgR";
            this.avgR.Size = new System.Drawing.Size(0, 13);
            this.avgR.TabIndex = 9;
            // 
            // cBar
            // 
            this.cBar.LargeChange = 1;
            this.cBar.Location = new System.Drawing.Point(33, 448);
            this.cBar.Name = "cBar";
            this.cBar.Size = new System.Drawing.Size(349, 45);
            this.cBar.TabIndex = 13;
            this.cBar.Scroll += new System.EventHandler(this.cBar_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Contrast";
            // 
            // pictureInit
            // 
            this.pictureInit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureInit.Location = new System.Drawing.Point(21, 85);
            this.pictureInit.Name = "pictureInit";
            this.pictureInit.Size = new System.Drawing.Size(400, 320);
            this.pictureInit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInit.TabIndex = 16;
            this.pictureInit.TabStop = false;
            // 
            // widthUpDown
            // 
            this.widthUpDown.Location = new System.Drawing.Point(36, 500);
            this.widthUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.widthUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.widthUpDown.Name = "widthUpDown";
            this.widthUpDown.Size = new System.Drawing.Size(120, 20);
            this.widthUpDown.TabIndex = 17;
            this.widthUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // heightUpDown
            // 
            this.heightUpDown.Location = new System.Drawing.Point(205, 500);
            this.heightUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.heightUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.heightUpDown.Name = "heightUpDown";
            this.heightUpDown.Size = new System.Drawing.Size(120, 20);
            this.heightUpDown.TabIndex = 18;
            this.heightUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // operationUpDown
            // 
            this.operationUpDown.Location = new System.Drawing.Point(33, 543);
            this.operationUpDown.Name = "operationUpDown";
            this.operationUpDown.Size = new System.Drawing.Size(120, 20);
            this.operationUpDown.TabIndex = 19;
            this.operationUpDown.Text = "Operation";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(205, 543);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 20;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(36, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 23);
            this.button1.TabIndex = 21;
            this.button1.Text = "Load Binary";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Relax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 585);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.operationUpDown);
            this.Controls.Add(this.heightUpDown);
            this.Controls.Add(this.widthUpDown);
            this.Controls.Add(this.pictureInit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBar);
            this.Controls.Add(this.avgR);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.pictureSource);
            this.Name = "Relax";
            this.Text = "Relax";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.widthUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSource;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label avgR;
        private System.Windows.Forms.TrackBar cBar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureInit;
        private System.Windows.Forms.NumericUpDown widthUpDown;
        private System.Windows.Forms.NumericUpDown heightUpDown;
        private System.Windows.Forms.DomainUpDown operationUpDown;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button button1;
    }
}

