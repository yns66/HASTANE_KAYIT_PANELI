namespace Proje_Hastane
{
    partial class FrmGirisler
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGirisler));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnHastaGirisi = new System.Windows.Forms.PictureBox();
            this.BtnDoktorGirisi = new System.Windows.Forms.PictureBox();
            this.BtnSekreterGirisi = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHastaGirisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDoktorGirisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSekreterGirisi)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(450, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(344, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnHastaGirisi
            // 
            this.BtnHastaGirisi.Image = ((System.Drawing.Image)(resources.GetObject("BtnHastaGirisi.Image")));
            this.BtnHastaGirisi.Location = new System.Drawing.Point(12, 218);
            this.BtnHastaGirisi.Name = "BtnHastaGirisi";
            this.BtnHastaGirisi.Size = new System.Drawing.Size(225, 132);
            this.BtnHastaGirisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnHastaGirisi.TabIndex = 1;
            this.BtnHastaGirisi.TabStop = false;
            this.BtnHastaGirisi.Click += new System.EventHandler(this.BtnHastaGirisi_Click);
            // 
            // BtnDoktorGirisi
            // 
            this.BtnDoktorGirisi.Image = ((System.Drawing.Image)(resources.GetObject("BtnDoktorGirisi.Image")));
            this.BtnDoktorGirisi.Location = new System.Drawing.Point(278, 218);
            this.BtnDoktorGirisi.Name = "BtnDoktorGirisi";
            this.BtnDoktorGirisi.Size = new System.Drawing.Size(254, 132);
            this.BtnDoktorGirisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnDoktorGirisi.TabIndex = 2;
            this.BtnDoktorGirisi.TabStop = false;
            this.BtnDoktorGirisi.Click += new System.EventHandler(this.BtnDoktorGirisi_Click);
            // 
            // BtnSekreterGirisi
            // 
            this.BtnSekreterGirisi.Image = ((System.Drawing.Image)(resources.GetObject("BtnSekreterGirisi.Image")));
            this.BtnSekreterGirisi.Location = new System.Drawing.Point(567, 218);
            this.BtnSekreterGirisi.Name = "BtnSekreterGirisi";
            this.BtnSekreterGirisi.Size = new System.Drawing.Size(227, 132);
            this.BtnSekreterGirisi.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnSekreterGirisi.TabIndex = 3;
            this.BtnSekreterGirisi.TabStop = false;
            this.BtnSekreterGirisi.Click += new System.EventHandler(this.BtnSekreterGirisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 61);
            this.label1.TabIndex = 4;
            this.label1.Text = "Sea Green Hospital";
            // 
            // FrmGirisler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(806, 414);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnSekreterGirisi);
            this.Controls.Add(this.BtnDoktorGirisi);
            this.Controls.Add(this.BtnHastaGirisi);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "FrmGirisler";
            this.Text = "Sea Green Hospital Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnHastaGirisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnDoktorGirisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSekreterGirisi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox BtnHastaGirisi;
        private System.Windows.Forms.PictureBox BtnDoktorGirisi;
        private System.Windows.Forms.PictureBox BtnSekreterGirisi;
        private System.Windows.Forms.Label label1;
    }
}

