
namespace QuanLyTiemChung
{
    partial class fNhanVien_YBacSi_XemLich
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewLichLamViec = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichLamViec)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(36, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Lịch làm việc của nhân viên";
            // 
            // dataGridViewLichLamViec
            // 
            this.dataGridViewLichLamViec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLichLamViec.Location = new System.Drawing.Point(31, 76);
            this.dataGridViewLichLamViec.Name = "dataGridViewLichLamViec";
            this.dataGridViewLichLamViec.RowHeadersWidth = 51;
            this.dataGridViewLichLamViec.RowTemplate.Height = 24;
            this.dataGridViewLichLamViec.Size = new System.Drawing.Size(540, 414);
            this.dataGridViewLichLamViec.TabIndex = 16;
            // 
            // fNhanVien_YBacSi_XemLich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(601, 502);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewLichLamViec);
            this.Name = "fNhanVien_YBacSi_XemLich";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Xem lịch làm việc";
            this.Load += new System.EventHandler(this.fNhanVien_YBacSi_XemLich_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLichLamViec)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewLichLamViec;
    }
}