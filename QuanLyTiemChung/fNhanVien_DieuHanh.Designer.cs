
namespace QuanLyTiemChung
{
    partial class fNhanVien_DieuHanh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fNhanVien_DieuHanh));
            this.buttonXemLich = new System.Windows.Forms.Button();
            this.buttonXepLich = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonXemLich
            // 
            this.buttonXemLich.BackColor = System.Drawing.Color.Green;
            this.buttonXemLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXemLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXemLich.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXemLich.Location = new System.Drawing.Point(493, 293);
            this.buttonXemLich.Name = "buttonXemLich";
            this.buttonXemLich.Size = new System.Drawing.Size(275, 130);
            this.buttonXemLich.TabIndex = 16;
            this.buttonXemLich.Text = "Xem lịch làm việc của nhân viên";
            this.buttonXemLich.UseVisualStyleBackColor = false;
            this.buttonXemLich.Click += new System.EventHandler(this.buttonXemLich_Click);
            // 
            // buttonXepLich
            // 
            this.buttonXepLich.BackColor = System.Drawing.Color.Green;
            this.buttonXepLich.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXepLich.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonXepLich.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonXepLich.Location = new System.Drawing.Point(79, 293);
            this.buttonXepLich.Name = "buttonXepLich";
            this.buttonXepLich.Size = new System.Drawing.Size(272, 130);
            this.buttonXepLich.TabIndex = 15;
            this.buttonXepLich.Text = "Sắp Xếp lịch làm việc";
            this.buttonXepLich.UseVisualStyleBackColor = false;
            this.buttonXepLich.Click += new System.EventHandler(this.buttonXepLich_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(119, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(528, 41);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // fNhanVien_DieuHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(820, 487);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonXemLich);
            this.Controls.Add(this.buttonXepLich);
            this.Name = "fNhanVien_DieuHanh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nhân viên điều hành";
            this.Load += new System.EventHandler(this.fNhanVien_DieuHanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonXemLich;
        private System.Windows.Forms.Button buttonXepLich;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}