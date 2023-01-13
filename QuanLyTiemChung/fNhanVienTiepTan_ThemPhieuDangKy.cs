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
    public partial class fNhanVienTiepTan_ThemPhieuDangKy : Form
    {
        public fNhanVienTiepTan_ThemPhieuDangKy()
        {
            InitializeComponent();
        }
        
        SqlConnection conn = new SqlConnection(ConnectionString.connString);
        
        private void openConn()
        {
            if (conn.State == ConnectionState.Closed)
                conn.Open();
        }

        private void closeConn()
        {
            if (conn.State == ConnectionState.Open)
                conn.Close();
        }

        private Boolean Exe(string cmd)
        {
            openConn();
            Boolean check;
            try
            {
                SqlCommand sc = new SqlCommand(cmd, conn);
                sc.ExecuteNonQuery();
                check = true;
            }
            catch (Exception)
            {
                check = false;
            }
            closeConn();
            return check;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cnt = 1;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM PhieuDangKy", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cnt++;
            }

            DateTime NgayLap = DateTime.Today;
            Exe("INSERT INTO PhieuDangKy(MaPDK, NgayLap, NVGhiNhan) VALUES('PDK" + cnt.ToString() + "', '" + NgayLap.ToString("yyyy-MM-dd") + "', 'NV000001')");

            DateTime dateOfBirth = Convert.ToDateTime(dateTimePicker1.Value);
            string gender = "";
            if (checkBox1.CheckState == CheckState.Checked)
                gender = "Nam";
            if (checkBox2.CheckState == CheckState.Checked)
                gender = "Nữ";
            Exe("INSERT INTO KhachHang(MaKH, HoTenKH, NgaySinh, GioiTinh, DiaChi, Phone, MaPDK) VALUES ('KH" + cnt.ToString() + "', N'" + textBox1.Text + "', '" + dateOfBirth.ToString("yyyy-MM-dd") + "', N'" + gender + "', N'" + textBox2.Text + "', '" + textBox3.Text + "', 'PDK" + cnt.ToString() + "') ");
            
            if (NgayLap.Year - dateOfBirth.Year < 16)
                Exe("INSERT INTO TreEm(MaKH, HoTenNguoiGiamHo, QuanHe, PhoneNguoiGiamHo) VALUES ('KH" + cnt.ToString() + "', N'" + textBox5.Text + "', N'" + textBox7.Text + "', '" + textBox6.Text + "')");

            string str = "Thêm khách hàng và lưu phiếu đăng ký thành công";
            MessageBox.Show(str);
        }
    
        private void button2_Click(object sender, EventArgs e)
        {
            int cnt = 1;
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM KhachHang", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            foreach (DataRow row in dt.Rows)
            {
                cnt++;
            }

            DateTime NgayLap = DateTime.Today;
            Exe("INSERT INTO PhieuDangKy(MaPDK, NgayLap, NVGhiNhan) VALUES('PDK" + cnt.ToString() + "', '" + NgayLap.ToString("yyyy-MM-dd") + "', 'NV000001')");

            DateTime dateOfBirth = Convert.ToDateTime(dateTimePicker1.Value);
            string gender = "";
            if (checkBox1.CheckState == CheckState.Checked)
                gender = "Nam";
            if (checkBox2.CheckState == CheckState.Checked)
                gender = "Nữ";
            Exe("INSERT INTO KhachHang(MaKH, HoTenKH, NgaySinh, GioiTinh, DiaChi, Phone, MaPDK) VALUES ('KH" + cnt.ToString() + "', N'" + textBox1.Text + "', '" + dateOfBirth.ToString("yyyy-MM-dd") + "', N'" + gender + "', N'" + textBox2.Text + "', '" + textBox3.Text + "', 'PDK" + cnt.ToString() + "') ");

            if (NgayLap.Year - dateOfBirth.Year < 16)
                Exe("INSERT INTO TreEm(MaKH, HoTenNguoiGiamHo, QuanHe, PhoneNguoiGiamHo) VALUES ('KH" + cnt.ToString() + "', N'" + textBox5.Text + "', N'" + textBox7.Text + "', '" + textBox6.Text + "')");

            string str = "Thêm khách hàng và gửi yêu cầu đặt mua vaccine thành công";
            MessageBox.Show(str);
        }

        private void fNhanVienTiepTan_ThemPhieuDangKy_Load(object sender, EventArgs e)
        {
            string query = "SELECT TenVaccine FROM DanhSachVaccine";
            DataTable dt = new DataTable();
            using (SqlConnection conn = new SqlConnection(ConnectionString.connString))
            {
                conn.Open();
                SqlDataAdapter adpter = new SqlDataAdapter(query, conn);
                adpter.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    comboBox1.Items.Add(dr["TenVaccine"].ToString());
                }
                conn.Close();
            }
        }
    }
}
