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
    public partial class fNhanVien_YBacSi_DangKy : Form
    {
        string ma;
        public fNhanVien_YBacSi_DangKy(string ma0)
        {
            ma = ma0;
            InitializeComponent();
        }

        private void fNhanVien_YBacSi_DangKy_Load(object sender, EventArgs e)
        {
            comboBoxCa.Items.Add("Sáng");
            comboBoxCa.Items.Add("Chiều");
            comboBoxCa.Items.Add("Tối");
            dataGridViewLichRanh_Load();
        }
        private void dataGridViewLichRanh_Load()
        {
            dataGridViewLichRanh.DataSource = BUS.LichRanh.layLichLamViecThemMaNV(ma);
        }
        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            if(comboBoxCa.SelectedIndex == -1)
            {
                MessageBox.Show("Ca không được để trống");
                return;
            }
            BUS.LichRanh lr = new BUS.LichRanh(ma, dateTimePicker1.Value.Date.ToString("yyyyMMdd"), comboBoxCa.SelectedItem.ToString());
            bool isTrue = lr.themLichRanh();
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
    }
}
