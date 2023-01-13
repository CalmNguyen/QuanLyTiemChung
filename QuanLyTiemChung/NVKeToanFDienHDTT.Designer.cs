using System.Windows.Forms;

namespace QuanLyTiemChung
{
    partial class NVKeToanFDienHDTT
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.Ma = new System.Windows.Forms.Label();
            this.textBoxMaPDK = new System.Windows.Forms.TextBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxMaKH = new System.Windows.Forms.TextBox();
            this.buttonLapHoaDon = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.dateTimePikerNgayTTTiepTheo = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.comboBoxPhuongThucGuiTien = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboBoxSoDotThanhToan = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ComboBoxLoaiThanhToan = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.YellowGreen;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.buttonLapHoaDon);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(19, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(498, 418);
            this.panel1.TabIndex = 3;
            this.panel1.TabStop = true;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.Ma);
            this.panel11.Controls.Add(this.textBoxMaPDK);
            this.panel11.Location = new System.Drawing.Point(21, 38);
            this.panel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(458, 33);
            this.panel11.TabIndex = 13;
            // 
            // Ma
            // 
            this.Ma.AutoSize = true;
            this.Ma.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.Ma.Location = new System.Drawing.Point(26, 11);
            this.Ma.Name = "Ma";
            this.Ma.Size = new System.Drawing.Size(134, 25);
            this.Ma.TabIndex = 1;
            this.Ma.Text = "Phiếu đăng ký";
            // 
            // textBoxMaPDK
            // 
            this.textBoxMaPDK.Location = new System.Drawing.Point(236, 11);
            this.textBoxMaPDK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaPDK.Name = "textBoxMaPDK";
            this.textBoxMaPDK.Size = new System.Drawing.Size(206, 22);
            this.textBoxMaPDK.TabIndex = 2;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label8);
            this.panel8.Controls.Add(this.textBoxMaKH);
            this.panel8.Location = new System.Drawing.Point(21, 80);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(458, 33);
            this.panel8.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(26, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Khách hàng";
            // 
            // textBoxMaKH
            // 
            this.textBoxMaKH.Location = new System.Drawing.Point(236, 11);
            this.textBoxMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxMaKH.Name = "textBoxMaKH";
            this.textBoxMaKH.Size = new System.Drawing.Size(206, 22);
            this.textBoxMaKH.TabIndex = 2;
            // 
            // buttonLapHoaDon
            // 
            this.buttonLapHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLapHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.buttonLapHoaDon.Location = new System.Drawing.Point(331, 358);
            this.buttonLapHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLapHoaDon.Name = "buttonLapHoaDon";
            this.buttonLapHoaDon.Size = new System.Drawing.Size(139, 32);
            this.buttonLapHoaDon.TabIndex = 9;
            this.buttonLapHoaDon.Text = "Lập hóa đơn";
            this.buttonLapHoaDon.UseVisualStyleBackColor = false;
            this.buttonLapHoaDon.Click += new System.EventHandler(this.buttonLapHoaDon_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.dateTimePikerNgayTTTiepTheo);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Location = new System.Drawing.Point(24, 288);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(455, 41);
            this.panel7.TabIndex = 8;
            // 
            // dateTimePikerNgayTTTiepTheo
            // 
            this.dateTimePikerNgayTTTiepTheo.Location = new System.Drawing.Point(200, 9);
            this.dateTimePikerNgayTTTiepTheo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePikerNgayTTTiepTheo.Name = "dateTimePikerNgayTTTiepTheo";
            this.dateTimePikerNgayTTTiepTheo.Size = new System.Drawing.Size(258, 22);
            this.dateTimePikerNgayTTTiepTheo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(20, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Ngày thanh toán TT";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.comboBoxPhuongThucGuiTien);
            this.panel6.Controls.Add(this.label6);
            this.panel6.Location = new System.Drawing.Point(20, 247);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(458, 37);
            this.panel6.TabIndex = 7;
            // 
            // comboBoxPhuongThucGuiTien
            // 
            this.comboBoxPhuongThucGuiTien.FormattingEnabled = true;
            this.comboBoxPhuongThucGuiTien.Items.AddRange(new object[] {
            "Trực Tiếp",
            "Online"});
            this.comboBoxPhuongThucGuiTien.Location = new System.Drawing.Point(236, 10);
            this.comboBoxPhuongThucGuiTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxPhuongThucGuiTien.Name = "comboBoxPhuongThucGuiTien";
            this.comboBoxPhuongThucGuiTien.Size = new System.Drawing.Size(205, 24);
            this.comboBoxPhuongThucGuiTien.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(26, 11);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Phương thức gửi tiền";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.comboBoxSoDotThanhToan);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Location = new System.Drawing.Point(20, 203);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(458, 40);
            this.panel4.TabIndex = 5;
            // 
            // comboBoxSoDotThanhToan
            // 
            this.comboBoxSoDotThanhToan.FormattingEnabled = true;
            this.comboBoxSoDotThanhToan.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxSoDotThanhToan.Location = new System.Drawing.Point(236, 10);
            this.comboBoxSoDotThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxSoDotThanhToan.Name = "comboBoxSoDotThanhToan";
            this.comboBoxSoDotThanhToan.Size = new System.Drawing.Size(205, 24);
            this.comboBoxSoDotThanhToan.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(26, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(168, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số đợt thanh toán";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ComboBoxLoaiThanhToan);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(21, 160);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(458, 40);
            this.panel3.TabIndex = 4;
            // 
            // ComboBoxLoaiThanhToan
            // 
            this.ComboBoxLoaiThanhToan.FormattingEnabled = true;
            this.ComboBoxLoaiThanhToan.Items.AddRange(new object[] {
            "Một đợt",
            "Nhiều đợt"});
            this.ComboBoxLoaiThanhToan.Location = new System.Drawing.Point(236, 10);
            this.ComboBoxLoaiThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComboBoxLoaiThanhToan.Name = "ComboBoxLoaiThanhToan";
            this.ComboBoxLoaiThanhToan.Size = new System.Drawing.Size(205, 24);
            this.ComboBoxLoaiThanhToan.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(26, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Loại thanh toán";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxTongTien);
            this.panel2.Location = new System.Drawing.Point(21, 117);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(458, 40);
            this.panel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(26, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tổng tiền";
            // 
            // textBoxTongTien
            // 
            this.textBoxTongTien.Location = new System.Drawing.Point(236, 11);
            this.textBoxTongTien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxTongTien.Name = "textBoxTongTien";
            this.textBoxTongTien.Size = new System.Drawing.Size(206, 22);
            this.textBoxTongTien.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(166, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hóa đơn thanh toán";
            // 
            // NVKeToanFDienHDTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 445);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "NVKeToanFDienHDTT";
            this.Text = "fHoaDonThanhToan";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel1;
        private Panel panel8;
        private Label label8;
        private TextBox textBoxMaKH;
        private Button buttonLapHoaDon;
        private Panel panel7;
        private DateTimePicker dateTimePikerNgayTTTiepTheo;
        private Label label7;
        private Panel panel6;
        private Label label6;
        private Panel panel4;
        private Label label4;
        private Panel panel3;
        private Label label3;
        private Panel panel2;
        private Label label2;
        private TextBox textBoxTongTien;
        private Label label1;
        private Panel panel11;
        private Label Ma;
        private TextBox textBoxMaPDK;
        private ComboBox comboBoxPhuongThucGuiTien;
        private ComboBox comboBoxSoDotThanhToan;
        private ComboBox ComboBoxLoaiThanhToan;
    }
}