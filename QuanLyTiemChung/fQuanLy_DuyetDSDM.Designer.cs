
namespace QuanLyTiemChung
{
    partial class fQuanLy_DuyetDSDM
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
            this.dataGridViewVaccineDM = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonDuyet = new System.Windows.Forms.Button();
            this.buttonKhongDuyet = new System.Windows.Forms.Button();
            this.textBoxNhaCungCap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccineDM)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVaccineDM
            // 
            this.dataGridViewVaccineDM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVaccineDM.Location = new System.Drawing.Point(12, 72);
            this.dataGridViewVaccineDM.Name = "dataGridViewVaccineDM";
            this.dataGridViewVaccineDM.RowHeadersWidth = 51;
            this.dataGridViewVaccineDM.RowTemplate.Height = 24;
            this.dataGridViewVaccineDM.Size = new System.Drawing.Size(517, 449);
            this.dataGridViewVaccineDM.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(33, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "Vaccine đặt mua";
            // 
            // buttonDuyet
            // 
            this.buttonDuyet.BackColor = System.Drawing.Color.Green;
            this.buttonDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDuyet.Location = new System.Drawing.Point(592, 84);
            this.buttonDuyet.Name = "buttonDuyet";
            this.buttonDuyet.Size = new System.Drawing.Size(275, 130);
            this.buttonDuyet.TabIndex = 31;
            this.buttonDuyet.Text = "Duyệt và thêm phiếu đặt hàng";
            this.buttonDuyet.UseVisualStyleBackColor = false;
            this.buttonDuyet.Click += new System.EventHandler(this.buttonDuyet_Click);
            // 
            // buttonKhongDuyet
            // 
            this.buttonKhongDuyet.BackColor = System.Drawing.Color.Green;
            this.buttonKhongDuyet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonKhongDuyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonKhongDuyet.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonKhongDuyet.Location = new System.Drawing.Point(592, 330);
            this.buttonKhongDuyet.Name = "buttonKhongDuyet";
            this.buttonKhongDuyet.Size = new System.Drawing.Size(275, 130);
            this.buttonKhongDuyet.TabIndex = 32;
            this.buttonKhongDuyet.Text = "Không duyệt";
            this.buttonKhongDuyet.UseVisualStyleBackColor = false;
            this.buttonKhongDuyet.Click += new System.EventHandler(this.buttonKhongDuyet_Click);
            // 
            // textBoxNhaCungCap
            // 
            this.textBoxNhaCungCap.Location = new System.Drawing.Point(668, 220);
            this.textBoxNhaCungCap.Multiline = true;
            this.textBoxNhaCungCap.Name = "textBoxNhaCungCap";
            this.textBoxNhaCungCap.Size = new System.Drawing.Size(248, 37);
            this.textBoxNhaCungCap.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Location = new System.Drawing.Point(535, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Nhà cung cấp";
            // 
            // fQuanLy_DuyetDSDM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(919, 533);
            this.Controls.Add(this.textBoxNhaCungCap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonKhongDuyet);
            this.Controls.Add(this.buttonDuyet);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVaccineDM);
            this.Name = "fQuanLy_DuyetDSDM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "fQuanLy_DuyetDSDM";
            this.Load += new System.EventHandler(this.fQuanLy_DuyetDSDM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVaccineDM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVaccineDM;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDuyet;
        private System.Windows.Forms.Button buttonKhongDuyet;
        private System.Windows.Forms.TextBox textBoxNhaCungCap;
        private System.Windows.Forms.Label label2;
    }
}