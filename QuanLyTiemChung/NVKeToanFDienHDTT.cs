using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace QuanLyTiemChung
{
    public partial class NVKeToanFDienHDTT : Form
    {
        
        public NVKeToanFDienHDTT()
        {
            InitializeComponent();
        }
        //xem tat ca du lieu
        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
        private void buttonLapHoaDon_Click(object sender, EventArgs e)
        {
            BUS.HoaDonThanhToan hdtt = new BUS.HoaDonThanhToan(textBoxMaPDK.Text, int.Parse(comboBoxSoDotThanhToan.Text), dateTimePikerNgayTTTiepTheo.Value, 
                                                               comboBoxPhuongThucGuiTien.Text, ComboBoxLoaiThanhToan.Text, float.Parse(textBoxTongTien.Text),
                                                               textBoxMaKH.Text.ToString());
            bool isTrue = hdtt.ThemHDTT();
            if (isTrue)
            {
                MessageBox.Show("Successed");
                this.Close();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}