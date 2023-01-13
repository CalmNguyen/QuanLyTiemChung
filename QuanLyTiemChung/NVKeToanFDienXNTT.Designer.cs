using System.Windows.Forms;

namespace QuanLyTiemChung
{
    partial class NVKeToanFDienXNTT
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonLapHoaDon = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateTimePikerNgayTTTiepTheo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxThanhTien = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxDotThanhToan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxMaHDTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.buttonLapHoaDon);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(10, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 351);
            this.panel1.TabIndex = 2;
            this.panel1.TabStop = true;
            // 
            // buttonLapHoaDon
            // 
            this.buttonLapHoaDon.AccessibleName = "";
            this.buttonLapHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLapHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.buttonLapHoaDon.Location = new System.Drawing.Point(328, 268);
            this.buttonLapHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLapHoaDon.Name = "buttonLapHoaDon";
            this.buttonLapHoaDon.Size = new System.Drawing.Size(132, 33);
            this.buttonLapHoaDon.TabIndex = 9;
            this.buttonLapHoaDon.Text = "Lập hóa đơn";
            this.buttonLapHoaDon.UseVisualStyleBackColor = false;
            this.buttonLapHoaDon.Click += new System.EventHandler(this.buttonLapHoaDon_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dateTimePikerNgayTTTiepTheo);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(19, 140);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(460, 41);
            this.panel7.TabIndex = 8;
            // 
            // dateTimePikerNgayTTTiepTheo
            // 
            this.dateTimePikerNgayTTTiepTheo.Location = new System.Drawing.Point(208, 10);
            this.dateTimePikerNgayTTTiepTheo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePikerNgayTTTiepTheo.Name = "dateTimePikerNgayTTTiepTheo";
            this.dateTimePikerNgayTTTiepTheo.Size = new System.Drawing.Size(233, 22);
            this.dateTimePikerNgayTTTiepTheo.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(3, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày thanh toán TT";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.textBoxThanhTien);
            this.panel5.Location = new System.Drawing.Point(19, 195);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(458, 40);
            this.panel5.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(26, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Thành tiền";
            // 
            // textBoxThanhTien
            // 
            this.textBoxThanhTien.Location = new System.Drawing.Point(236, 11);
            this.textBoxThanhTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxThanhTien.Name = "textBoxThanhTien";
            this.textBoxThanhTien.Size = new System.Drawing.Size(206, 22);
            this.textBoxThanhTien.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxDotThanhToan);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(19, 94);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 40);
            this.panel4.TabIndex = 5;
            // 
            // comboBoxDotThanhToan
            // 
            this.comboBoxDotThanhToan.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboBoxDotThanhToan.FormattingEnabled = true;
            this.comboBoxDotThanhToan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxDotThanhToan.Location = new System.Drawing.Point(236, 11);
            this.comboBoxDotThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxDotThanhToan.Name = "comboBoxDotThanhToan";
            this.comboBoxDotThanhToan.Size = new System.Drawing.Size(206, 31);
            this.comboBoxDotThanhToan.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Đợt thanh toán";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxMaHDTT);
            this.panel2.Location = new System.Drawing.Point(19, 50);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 40);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(-16, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã hóa đơn thanh toán";
            // 
            // textBoxMaHDTT
            // 
            this.textBoxMaHDTT.Location = new System.Drawing.Point(236, 11);
            this.textBoxMaHDTT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaHDTT.Name = "textBoxMaHDTT";
            this.textBoxMaHDTT.Size = new System.Drawing.Size(206, 22);
            this.textBoxMaHDTT.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(116, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn xác nhận thanh toán";
            // 
            // NVKeToanFDienXNTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 341);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NVKeToanFDienXNTT";
            this.Text = "Form xác nhận thanh toán";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button buttonLapHoaDon;
        private Panel panel5;
        private Label label5;
        private TextBox textBoxThanhTien;
        private Panel panel4;
        private ComboBox comboBoxDotThanhToan;
        private Label label4;
        private Panel panel2;
        private Label label2;
        private TextBox textBoxMaHDTT;
        private Label label1;
        private Panel panel7;
        private DateTimePicker dateTimePikerNgayTTTiepTheo;
        private Label label7;
    }
}