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
    public partial class fNhanVien_DieuHanh_XemLich : Form
    {
        public fNhanVien_DieuHanh_XemLich()
        {
            InitializeComponent();
        }

        private void fNhanVien_DieuHanh_XemLich_Load(object sender, EventArgs e)
        {

            dataGridViewLichLamViec.DataSource = BUS.LichLamViec.layAllLichLamViec();
        }
    }
}
