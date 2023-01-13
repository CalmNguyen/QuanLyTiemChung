
namespace QuanLyTiemChung
{
    partial class fNhanVien_TiepTan_XemDanhSachVaccine
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
            this.dataGridViewGoiVaccine = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoiVaccine)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewGoiVaccine
            // 
            this.dataGridViewGoiVaccine.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGoiVaccine.Location = new System.Drawing.Point(58, 92);
            this.dataGridViewGoiVaccine.Name = "dataGridViewGoiVaccine";
            this.dataGridViewGoiVaccine.RowHeadersWidth = 51;
            this.dataGridViewGoiVaccine.RowTemplate.Height = 24;
            this.dataGridViewGoiVaccine.Size = new System.Drawing.Size(622, 240);
            this.dataGridViewGoiVaccine.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(31, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Danh sách các vaccine";
            // 
            // fNhanVien_TiepTan_XemDanhSachVaccine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(711, 360);
            this.Controls.Add(this.dataGridViewGoiVaccine);
            this.Controls.Add(this.label1);
            this.Name = "fNhanVien_TiepTan_XemDanhSachVaccine";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Danh sách vaccine";
            this.Load += new System.EventHandler(this.fNhanVien_TiepTan_XemDanhSachVaccine_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGoiVaccine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewGoiVaccine;
        private System.Windows.Forms.Label label1;
    }
}