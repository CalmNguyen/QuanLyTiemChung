
namespace QuanLyTiemChung
{
    partial class fNhanVien_DieuHanh_SapXepLich
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
            this.buttonKhongDuyet = new System.Windows.Forms.Button();
            this.buttonDuyet = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLichRanh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichRanh)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonKhongDuyet
            // 
            this.buttonKhongDuyet.BackColor = System.Drawing.Color.Green;
            this.buttonKhongDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKhongDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhongDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKhongDuyet.Location = new System.Drawing.Point(580, 313);
            this.buttonKhongDuyet.Name = "buttonKhongDuyet";
            this.buttonKhongDuyet.Size = new System.Drawing.Size(167, 89);
            this.buttonKhongDuyet.TabIndex = 17;
            this.buttonKhongDuyet.Text = "Không duyệt";
            this.buttonKhongDuyet.UseVisualStyleBackColor = false;
            this.buttonKhongDuyet.Click += new System.EventHandler(this.buttonKhongDuyet_Click);
            // 
            // buttonDuyet
            // 
            this.buttonDuyet.BackColor = System.Drawing.Color.Green;
            this.buttonDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDuyet.Location = new System.Drawing.Point(580, 102);
            this.buttonDuyet.Name = "buttonDuyet";
            this.buttonDuyet.Size = new System.Drawing.Size(167, 89);
            this.buttonDuyet.TabIndex = 16;
            this.buttonDuyet.Text = "Duyệt";
            this.buttonDuyet.UseVisualStyleBackColor = false;
            this.buttonDuyet.Click += new System.EventHandler(this.buttonDuyet_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Lịch rảnh";
            // 
            // dataGridViewLichRanh
            // 
            this.dataGridViewLichRanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichRanh.Location = new System.Drawing.Point(28, 79);
            this.dataGridViewLichRanh.Name = "dataGridViewLichRanh";
            this.dataGridViewLichRanh.RowHeadersWidth = 51;
            this.dataGridViewLichRanh.RowTemplate.Height = 24;
            this.dataGridViewLichRanh.Size = new System.Drawing.Size(518, 414);
            this.dataGridViewLichRanh.TabIndex = 14;
            // 
            // fNhanVien_DieuHanh_SapXepLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(782, 517);
            this.Controls.Add(this.buttonKhongDuyet);
            this.Controls.Add(this.buttonDuyet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLichRanh);
            this.Name = "fNhanVien_DieuHanh_SapXepLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sắp xếp lịch";
            this.Load += new System.EventHandler(this.fNhanVien_DieuHanh_SapXepLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichRanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKhongDuyet;
        private System.Windows.Forms.Button buttonDuyet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLichRanh;
    }
}