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
    public partial class fNhanVien_YBacSi_XemLich : Form
    {
        string ma;
        public fNhanVien_YBacSi_XemLich(string ma0)
        {
            ma = ma0;
            InitializeComponent();
        }

        private void fNhanVien_YBacSi_XemLich_Load(object sender, EventArgs e)
        {
            dataGridViewLichLamViec.DataSource = BUS.LichLamViec.layLichLamViecTheoMaNV(ma);
        }
    }
}
