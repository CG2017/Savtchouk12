﻿namespace lab5
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.trackBarx1 = new System.Windows.Forms.TrackBar();
            this.trackBary1 = new System.Windows.Forms.TrackBar();
            this.trackBarx2 = new System.Windows.Forms.TrackBar();
            this.trackBary2 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarR = new System.Windows.Forms.TrackBar();
            this.numericUpDownx1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowny1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownx2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDowny2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownR = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBary1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBary2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownx1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowny1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownx2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowny2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBarx1
            // 
            this.trackBarx1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarx1.AutoSize = false;
            this.trackBarx1.Location = new System.Drawing.Point(619, 85);
            this.trackBarx1.Maximum = 100;
            this.trackBarx1.Name = "trackBarx1";
            this.trackBarx1.Size = new System.Drawing.Size(121, 28);
            this.trackBarx1.TabIndex = 13;
            this.trackBarx1.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // trackBary1
            // 
            this.trackBary1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBary1.AutoSize = false;
            this.trackBary1.Location = new System.Drawing.Point(619, 120);
            this.trackBary1.Maximum = 100;
            this.trackBary1.Name = "trackBary1";
            this.trackBary1.Size = new System.Drawing.Size(121, 28);
            this.trackBary1.TabIndex = 14;
            this.trackBary1.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // trackBarx2
            // 
            this.trackBarx2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarx2.AutoSize = false;
            this.trackBarx2.Location = new System.Drawing.Point(619, 154);
            this.trackBarx2.Maximum = 100;
            this.trackBarx2.Name = "trackBarx2";
            this.trackBarx2.Size = new System.Drawing.Size(121, 28);
            this.trackBarx2.TabIndex = 15;
            this.trackBarx2.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // trackBary2
            // 
            this.trackBary2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBary2.AutoSize = false;
            this.trackBary2.Location = new System.Drawing.Point(619, 195);
            this.trackBary2.Maximum = 100;
            this.trackBary2.Name = "trackBary2";
            this.trackBary2.Size = new System.Drawing.Size(121, 28);
            this.trackBary2.TabIndex = 16;
            this.trackBary2.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(545, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "y0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(545, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "x0";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(545, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "y1";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(545, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "x1";
            // 
            // zedGraph
            // 
            this.zedGraph.Cursor = System.Windows.Forms.Cursors.Default;
            this.zedGraph.Location = new System.Drawing.Point(36, 27);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0;
            this.zedGraph.ScrollMaxX = 0;
            this.zedGraph.ScrollMaxY = 0;
            this.zedGraph.ScrollMaxY2 = 0;
            this.zedGraph.ScrollMinX = 0;
            this.zedGraph.ScrollMinY = 0;
            this.zedGraph.ScrollMinY2 = 0;
            this.zedGraph.Size = new System.Drawing.Size(463, 456);
            this.zedGraph.TabIndex = 0;
            // 
            // domainUpDown
            // 
            this.domainUpDown.Location = new System.Drawing.Point(547, 40);
            this.domainUpDown.Name = "domainUpDown";
            this.domainUpDown.Size = new System.Drawing.Size(120, 20);
            this.domainUpDown.TabIndex = 26;
            this.domainUpDown.TextChanged += new System.EventHandler(this.trackBarScroll);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(545, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "R";
            // 
            // trackBarR
            // 
            this.trackBarR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarR.AutoSize = false;
            this.trackBarR.Location = new System.Drawing.Point(619, 229);
            this.trackBarR.Maximum = 100;
            this.trackBarR.Name = "trackBarR";
            this.trackBarR.Size = new System.Drawing.Size(121, 28);
            this.trackBarR.TabIndex = 27;
            this.trackBarR.Scroll += new System.EventHandler(this.trackBarScroll);
            // 
            // numericUpDownx1
            // 
            this.numericUpDownx1.Location = new System.Drawing.Point(569, 90);
            this.numericUpDownx1.Name = "numericUpDownx1";
            this.numericUpDownx1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownx1.TabIndex = 29;
            this.numericUpDownx1.ValueChanged += new System.EventHandler(this.numericUpDownx1_ValueChanged);
            // 
            // numericUpDowny1
            // 
            this.numericUpDowny1.Location = new System.Drawing.Point(569, 128);
            this.numericUpDowny1.Name = "numericUpDowny1";
            this.numericUpDowny1.Size = new System.Drawing.Size(44, 20);
            this.numericUpDowny1.TabIndex = 30;
            this.numericUpDowny1.ValueChanged += new System.EventHandler(this.numericUpDowny1_ValueChanged);
            // 
            // numericUpDownx2
            // 
            this.numericUpDownx2.Location = new System.Drawing.Point(569, 159);
            this.numericUpDownx2.Name = "numericUpDownx2";
            this.numericUpDownx2.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownx2.TabIndex = 31;
            this.numericUpDownx2.ValueChanged += new System.EventHandler(this.numericUpDownx2_ValueChanged);
            // 
            // numericUpDowny2
            // 
            this.numericUpDowny2.Location = new System.Drawing.Point(569, 195);
            this.numericUpDowny2.Name = "numericUpDowny2";
            this.numericUpDowny2.Size = new System.Drawing.Size(44, 20);
            this.numericUpDowny2.TabIndex = 32;
            this.numericUpDowny2.ValueChanged += new System.EventHandler(this.numericUpDowny2_ValueChanged);
            // 
            // numericUpDownR
            // 
            this.numericUpDownR.Location = new System.Drawing.Point(569, 227);
            this.numericUpDownR.Name = "numericUpDownR";
            this.numericUpDownR.Size = new System.Drawing.Size(44, 20);
            this.numericUpDownR.TabIndex = 33;
            this.numericUpDownR.ValueChanged += new System.EventHandler(this.numericUpDownR_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 518);
            this.Controls.Add(this.numericUpDownR);
            this.Controls.Add(this.numericUpDowny2);
            this.Controls.Add(this.numericUpDownx2);
            this.Controls.Add(this.numericUpDowny1);
            this.Controls.Add(this.numericUpDownx1);
            this.Controls.Add(this.zedGraph);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarR);
            this.Controls.Add(this.domainUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.trackBary2);
            this.Controls.Add(this.trackBarx2);
            this.Controls.Add(this.trackBary1);
            this.Controls.Add(this.trackBarx1);
            this.Name = "Form1";
            this.Text = "Rasterization";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBary1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBary2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownx1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowny1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownx2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDowny2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBarx1;
        private System.Windows.Forms.TrackBar trackBary1;
        private System.Windows.Forms.TrackBar trackBarx2;
        private System.Windows.Forms.TrackBar trackBary2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.DomainUpDown domainUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBarR;
        private System.Windows.Forms.NumericUpDown numericUpDownx1;
        private System.Windows.Forms.NumericUpDown numericUpDowny1;
        private System.Windows.Forms.NumericUpDown numericUpDownx2;
        private System.Windows.Forms.NumericUpDown numericUpDowny2;
        private System.Windows.Forms.NumericUpDown numericUpDownR;
    }
}

