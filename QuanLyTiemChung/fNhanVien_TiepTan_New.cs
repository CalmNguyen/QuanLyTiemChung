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
    public partial class fNhanVien_TiepTan_New : Form
    {
        string manv;
        public fNhanVien_TiepTan_New(string manv0)
        {
            manv = manv0;
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            fNhanVien_TiepTan_ThemPhieuDangKy f = new fNhanVien_TiepTan_ThemPhieuDangKy(manv);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonXem_Click(object sender, EventArgs e)
        {
            fNhanVien_TiepTan_XemDanhSachVaccine f = new fNhanVien_TiepTan_XemDanhSachVaccine();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fNhanVienTiepTan_Load(object sender, EventArgs e)
        {

        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            fNhanVien_YBacSi_DangKy f = new fNhanVien_YBacSi_DangKy(manv);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void buttonXemLichLamViec_Click(object sender, EventArgs e)
        {
            fNhanVien_YBacSi_XemLich f = new fNhanVien_YBacSi_XemLich(manv);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fNhanVien_TiepTan f = new fNhanVien_TiepTan(manv);
            this.Close();
            f.ShowDialog();
            this.Show();
        }
    }
}
