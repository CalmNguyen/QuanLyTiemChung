using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyTiemChung
{
    public partial class NVKeToan : Form
    {
        string ma;
        public NVKeToan(string ma0)
        {
            ma = ma0;
            InitializeComponent();
        }

        private void FDienHDTT_Click(object sender, EventArgs e)
        {
            NVKeToanFDienHDTT form = new NVKeToanFDienHDTT();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void FDienXNTT_Click(object sender, EventArgs e)
        {
            NVKeToanFDienXNTT form = new NVKeToanFDienXNTT();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void NVKeToan_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NVKeToanFDienHDTT form = new NVKeToanFDienHDTT();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NVKeToanFDienXNTT form = new NVKeToanFDienXNTT();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            fNhanVien_YBacSi_DangKy f = new fNhanVien_YBacSi_DangKy(ma);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonXemLichLamViec_Click(object sender, EventArgs e)
        {
            fNhanVien_YBacSi_XemLich f = new fNhanVien_YBacSi_XemLich(ma);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
