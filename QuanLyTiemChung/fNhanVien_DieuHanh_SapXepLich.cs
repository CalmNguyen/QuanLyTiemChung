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
    public partial class fNhanVien_DieuHanh_SapXepLich : Form
    {
        public fNhanVien_DieuHanh_SapXepLich()
        {
            InitializeComponent();
        }

        private void fNhanVien_DieuHanh_SapXepLich_Load(object sender, EventArgs e)
        {
            dataGridViewLichRanh_Load();
        }

        private void dataGridViewLichRanh_Load()
        {
            
            dataGridViewLichRanh.DataSource = BUS.LichRanh.layAllLichRanh();
        }

        private void buttonDuyet_Click(object sender, EventArgs e)
        {
            string manv, ngay, ca;
            manv = dataGridViewLichRanh.CurrentRow.Cells["MaNV"].Value.ToString();
            ngay = dataGridViewLichRanh.CurrentRow.Cells["Ngay"].Value.ToString();
            ca = dataGridViewLichRanh.CurrentRow.Cells["Ca"].Value.ToString();
            BUS.LichRanh lr = new BUS.LichRanh(manv,ngay,ca);
            BUS.LichLamViec llv = new BUS.LichLamViec(manv,ngay,ca);
            bool isTrue = lr.xoaLichRanh() && llv.themLichLamViec();

            if (isTrue)
            {
                MessageBox.Show("Successed");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            dataGridViewLichRanh_Load();
        }

        private void buttonKhongDuyet_Click(object sender, EventArgs e)
        {
            BUS.LichRanh lr = new BUS.LichRanh(dataGridViewLichRanh.CurrentRow.Cells["MaNV"].Value.ToString(),
                                                dataGridViewLichRanh.CurrentRow.Cells["Ngay"].Value.ToString(),
                                                dataGridViewLichRanh.CurrentRow.Cells["Ca"].Value.ToString());

            bool isTrueDelete = lr.xoaLichRanh();
            if (isTrueDelete)
            {
                MessageBox.Show("Successed");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            dataGridViewLichRanh_Load();
        }
    }
}
