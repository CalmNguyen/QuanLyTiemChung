using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyTiemChung
{
    public partial class NVKeToanFDienXNTT : Form
    {
        public NVKeToanFDienXNTT()
        {
            InitializeComponent();
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }
        

        private void buttonLapHoaDon_Click(object sender, EventArgs e)
        {
            BUS.XacNhanThanhToan xntt = new BUS.XacNhanThanhToan(textBoxMaHDTT.Text, int.Parse(comboBoxDotThanhToan.Text), 
                                                      float.Parse(textBoxThanhTien.Text), dateTimePikerNgayTTTiepTheo.Value);
            
            bool isTrue = xntt.ThemXNTT();
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
