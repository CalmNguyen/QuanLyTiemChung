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
    public partial class fNhanVien_YBacSi : Form
    {
        string ma;
        public fNhanVien_YBacSi(string ma0)
        {
            ma = ma0;
            InitializeComponent();
        }

        private void buttonXemLich_Click(object sender, EventArgs e)
        {
            fNhanVien_YBacSi_XemLich f = new fNhanVien_YBacSi_XemLich(ma);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void fNhanVien_YBacSi_Load(object sender, EventArgs e)
        {

        }

        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            fNhanVien_YBacSi_DangKy f = new fNhanVien_YBacSi_DangKy(ma);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }
    }
}
