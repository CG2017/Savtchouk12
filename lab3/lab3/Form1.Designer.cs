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
            this.hiR = new System.Windows.Forms.PictureBox();
            this.hiG = new System.Windows.Forms.PictureBox();
            this.hiB = new System.Windows.Forms.PictureBox();
            this.loadButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.avgR = new System.Windows.Forms.Label();
            this.avgG = new System.Windows.Forms.Label();
            this.avgB = new System.Windows.Forms.Label();
            this.bBar = new System.Windows.Forms.TrackBar();
            this.cBar = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureSource
            // 
            this.pictureSource.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureSource.Location = new System.Drawing.Point(33, 69);
            this.pictureSource.Name = "pictureSource";
            this.pictureSource.Size = new System.Drawing.Size(400, 262);
            this.pictureSource.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureSource.TabIndex = 0;
            this.pictureSource.TabStop = false;
            // 
            // hiR
            // 
            this.hiR.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hiR.Location = new System.Drawing.Point(505, 12);
            this.hiR.Name = "hiR";
            this.hiR.Size = new System.Drawing.Size(182, 141);
            this.hiR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hiR.TabIndex = 1;
            this.hiR.TabStop = false;
            // 
            // hiG
            // 
            this.hiG.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hiG.Location = new System.Drawing.Point(505, 178);
            this.hiG.Name = "hiG";
            this.hiG.Size = new System.Drawing.Size(182, 153);
            this.hiG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hiG.TabIndex = 3;
            this.hiG.TabStop = false;
            // 
            // hiB
            // 
            this.hiB.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.hiB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.hiB.Location = new System.Drawing.Point(505, 350);
            this.hiB.Name = "hiB";
            this.hiB.Size = new System.Drawing.Size(182, 153);
            this.hiB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.hiB.TabIndex = 4;
            this.hiB.TabStop = false;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(467, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "R";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(456, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "G";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(457, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // avgR
            // 
            this.avgR.AutoSize = true;
            this.avgR.Location = new System.Drawing.Point(502, 156);
            this.avgR.Name = "avgR";
            this.avgR.Size = new System.Drawing.Size(0, 13);
            this.avgR.TabIndex = 9;
            // 
            // avgG
            // 
            this.avgG.AutoSize = true;
            this.avgG.Location = new System.Drawing.Point(502, 334);
            this.avgG.Name = "avgG";
            this.avgG.Size = new System.Drawing.Size(0, 13);
            this.avgG.TabIndex = 10;
            // 
            // avgB
            // 
            this.avgB.AutoSize = true;
            this.avgB.Location = new System.Drawing.Point(502, 506);
            this.avgB.Name = "avgB";
            this.avgB.Size = new System.Drawing.Size(0, 13);
            this.avgB.TabIndex = 11;
            // 
            // bBar
            // 
            this.bBar.Location = new System.Drawing.Point(33, 367);
            this.bBar.Maximum = 100;
            this.bBar.Name = "bBar";
            this.bBar.Size = new System.Drawing.Size(349, 45);
            this.bBar.TabIndex = 12;
            this.bBar.Value = 50;
            this.bBar.Scroll += new System.EventHandler(this.bBar_Scroll);
            // 
            // cBar
            // 
            this.cBar.Location = new System.Drawing.Point(33, 448);
            this.cBar.Maximum = 100;
            this.cBar.Minimum = -100;
            this.cBar.Name = "cBar";
            this.cBar.Size = new System.Drawing.Size(349, 45);
            this.cBar.TabIndex = 13;
            this.cBar.Scroll += new System.EventHandler(this.cBar_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 350);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Brightness";
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
            // Relax
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 585);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cBar);
            this.Controls.Add(this.bBar);
            this.Controls.Add(this.avgB);
            this.Controls.Add(this.avgG);
            this.Controls.Add(this.avgR);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.hiB);
            this.Controls.Add(this.hiG);
            this.Controls.Add(this.hiR);
            this.Controls.Add(this.pictureSource);
            this.Name = "Relax";
            this.Text = "Relax";
            ((System.ComponentModel.ISupportInitialize)(this.pictureSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureSource;
        private System.Windows.Forms.PictureBox hiR;
        private System.Windows.Forms.PictureBox hiG;
        private System.Windows.Forms.PictureBox hiB;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label avgR;
        private System.Windows.Forms.Label avgG;
        private System.Windows.Forms.Label avgB;
        private System.Windows.Forms.TrackBar bBar;
        private System.Windows.Forms.TrackBar cBar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

