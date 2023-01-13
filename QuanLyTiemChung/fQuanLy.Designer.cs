
namespace QuanLyTiemChung
{
    partial class fQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanLy));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonDSDMVC = new System.Windows.Forms.Button();
            this.buttonDSPDH = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(505, 34);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(207, 222);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(207, 222);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // buttonDSDMVC
            // 
            this.buttonDSDMVC.BackColor = System.Drawing.Color.Green;
            this.buttonDSDMVC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDSDMVC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDSDMVC.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDSDMVC.Location = new System.Drawing.Point(470, 286);
            this.buttonDSDMVC.Name = "buttonDSDMVC";
            this.buttonDSDMVC.Size = new System.Drawing.Size(275, 130);
            this.buttonDSDMVC.TabIndex = 30;
            this.buttonDSDMVC.Text = "Duyệt danh sách đặt mua Vaccine";
            this.buttonDSDMVC.UseVisualStyleBackColor = false;
            this.buttonDSDMVC.Click += new System.EventHandler(this.buttonDSDMVC_Click);
            // 
            // buttonDSPDH
            // 
            this.buttonDSPDH.BackColor = System.Drawing.Color.Green;
            this.buttonDSPDH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDSPDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDSPDH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDSPDH.Location = new System.Drawing.Point(56, 286);
            this.buttonDSPDH.Name = "buttonDSPDH";
            this.buttonDSPDH.Size = new System.Drawing.Size(272, 130);
            this.buttonDSPDH.TabIndex = 29;
            this.buttonDSPDH.Text = "Danh sách phiếu đặt hàng";
            this.buttonDSPDH.UseVisualStyleBackColor = false;
            this.buttonDSPDH.Click += new System.EventHandler(this.buttonDSPDH_Click);
            // 
            // fQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonDSDMVC);
            this.Controls.Add(this.buttonDSPDH);
            this.Name = "fQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fQuanLy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonDSDMVC;
        private System.Windows.Forms.Button buttonDSPDH;
    }
}