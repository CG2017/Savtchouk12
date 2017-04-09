namespace lab4
{
    partial class ImForm
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
            this.ImageTable = new System.Windows.Forms.DataGridView();
            this.openButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.progressLabel = new System.Windows.Forms.Label();
            this.pictureView = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).BeginInit();
            this.SuspendLayout();
            // 
            // ImageTable
            // 
            this.ImageTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ImageTable.Location = new System.Drawing.Point(32, 12);
            this.ImageTable.Name = "ImageTable";
            this.ImageTable.Size = new System.Drawing.Size(620, 220);
            this.ImageTable.TabIndex = 0;
            this.ImageTable.SelectionChanged += new System.EventHandler(this.ImageTable_SelectionChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(32, 251);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(142, 23);
            this.openButton.TabIndex = 1;
            this.openButton.Text = "Open files";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(210, 250);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(136, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Clear files";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(51, 313);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(42, 13);
            this.progressLabel.TabIndex = 3;
            this.progressLabel.Text = "No files";
            // 
            // pictureView
            // 
            this.pictureView.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureView.Location = new System.Drawing.Point(366, 250);
            this.pictureView.Name = "pictureView";
            this.pictureView.Size = new System.Drawing.Size(333, 230);
            this.pictureView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureView.TabIndex = 4;
            this.pictureView.TabStop = false;
            // 
            // ImForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 492);
            this.Controls.Add(this.pictureView);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.openButton);
            this.Controls.Add(this.ImageTable);
            this.Name = "ImForm";
            this.Text = "ImForm";
            ((System.ComponentModel.ISupportInitialize)(this.ImageTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ImageTable;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label progressLabel;
        private System.Windows.Forms.PictureBox pictureView;
    }
}

