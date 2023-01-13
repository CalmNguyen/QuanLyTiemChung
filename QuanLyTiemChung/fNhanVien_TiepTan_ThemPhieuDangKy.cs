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
    public partial class fNhanVien_TiepTan_ThemPhieuDangKy : Form
    {
        string manv;
        public fNhanVien_TiepTan_ThemPhieuDangKy(string manv0)
        {
            manv = manv0;
            InitializeComponent();
        }
        //khai báo biến delegate
        delegate int DeCheckNULL();
        private int CheckNULL()
        {
            if(textBoxHoten.Text.Length==0)
            {
                MessageBox.Show("Họ tên không thể bỏ trống");
                return 0;
            }
            if((checkBoxNam.CheckState == CheckState.Unchecked) && (checkBoxNu.CheckState == CheckState.Unchecked))
            {
                MessageBox.Show("Giới tính không thể bỏ trống");
                return 0;
            }    
            if(textBoxDiaChi.Text.Length==0)
            {
                MessageBox.Show("Địa chỉ không thể bỏ trống");
                return 0;
            }
            if (textBoxSDT.Text.Length == 0)
            {
                MessageBox.Show("Số điện thoại không thể bỏ trống");
                return 0;
            }
            if(comboBoxGoiVaccine.SelectedItem.ToString().Split(' ')[0].Length ==0)
            {
                MessageBox.Show("Gói vaccine đặt mua không thể bỏ trống");
                return 0;
            }

            return 1;
        }
        private int CheckNullVaccine()
        {
            if (textBoxTenVaccineDatMua.Text.Length != 0 && textBoxSoLuongDatMua.Text.Length == 0)
            {
                MessageBox.Show("Số lượng vaccine không thể bỏ trống");
                return 0;
            }
            else if (textBoxTenVaccineDatMua.Text.Length == 0 && textBoxSoLuongDatMua.Text.Length != 0)
            {
                MessageBox.Show("Tên vaccine không thể bỏ trống");
                return 0;
            }
            else if (textBoxTenVaccineDatMua.Text.Length == 0 && textBoxSoLuongDatMua.Text.Length == 0)
            {
                MessageBox.Show("Thông tin đặt mua vaccine không thể bỏ trống");
                return 0;
            }
            return 1;
        }
        private void buttonDangKy_Click(object sender, EventArgs e)
        {
            //áp dụng sử dụng delegate
            DeCheckNULL deCheckNULL = new DeCheckNULL(CheckNULL);
            if (deCheckNULL()==0)
                return;
            string gioiTinh = "";
            if (checkBoxNam.CheckState == CheckState.Checked)
                gioiTinh = "Nam";
            if (checkBoxNu.CheckState == CheckState.Checked)
                gioiTinh = "Nữ";

            BUS.KhachHang kh = new BUS.KhachHang(textBoxHoten.Text, dateTimePickerNgaySinh.Value.Date.ToString("yyyyMMdd"), gioiTinh, textBoxDiaChi.Text, textBoxSDT.Text);

            string goiVaccine = comboBoxGoiVaccine.SelectedItem.ToString().Split(' ')[0];
            string ngayLap = DateTime.Today.ToString("yyyy-MM-dd");
            //khong can new phieu dang ky moi
            BUS.PhieuDangKi pdk = BUS.PhieuDangKi.GetPhieuDangKi(ngayLap, goiVaccine, dateTimePickerNgayTiem.Value.Date.ToString("yyyyMMdd"), manv, kh.getMakh());
            bool isTrue;
            if(textBoxHoTenNguoiGiamHo.Text == "")
            {
                isTrue = kh.themKhachHang() && pdk.themPhieuDangKy();
            }
            else
            {
                BUS.TreEm te = new BUS.TreEm(kh.getMakh(), textBoxHoTenNguoiGiamHo.Text, textBoxMQH.Text, textBoxSDTNguoiGiamHo.Text);
                isTrue = kh.themKhachHang() && pdk.themPhieuDangKy() && te.themTreEm();
            }
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


        private void buttonDatMua_Click(object sender, EventArgs e)
        {
            //áp dụng sử dụng delegate
            DeCheckNULL deCheckNULL = new DeCheckNULL(CheckNULL);
            DeCheckNULL deCheckVaccineNULL = new DeCheckNULL(CheckNullVaccine);
            /*if (deCheckNULL() == 0)
                return;
            if (deCheckVaccineNULL() == 0)
                return;*/
            DeCheckNULL multi = deCheckNULL + deCheckVaccineNULL;
            if (multi() == 0)
                return;
            //xong kiem tra validations
            string gioiTinh = "";
            if (checkBoxNam.CheckState == CheckState.Checked)
                gioiTinh = "Nam";
            if (checkBoxNu.CheckState == CheckState.Checked)
                gioiTinh = "Nữ";

            BUS.KhachHang kh = new BUS.KhachHang(textBoxHoten.Text, dateTimePickerNgaySinh.Value.Date.ToString("yyyyMMdd"), gioiTinh, textBoxDiaChi.Text, textBoxSDT.Text);
            bool isTrue = kh.themKhachHang();
            
            if (textBoxHoTenNguoiGiamHo.Text == "")
            {
                 isTrue = isTrue && BUS.DanhSachDatMuaVaccine.themDanhSachDatMuaVaccine(kh.getMakh(), textBoxTenVaccineDatMua.Text, textBoxSoLuongDatMua.Text);
            }
            else
            {
                BUS.TreEm te = new BUS.TreEm(kh.getMakh(), textBoxHoTenNguoiGiamHo.Text, textBoxMQH.Text, textBoxSDTNguoiGiamHo.Text);
                isTrue = isTrue && te.themTreEm() && BUS.DanhSachDatMuaVaccine.themDanhSachDatMuaVaccine(kh.getMakh(), textBoxTenVaccineDatMua.Text, textBoxSoLuongDatMua.Text);
            }
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

        private void fNhanVien_TiepTan_ThemPhieuDangKy_Load(object sender, EventArgs e)
        {
            DataTable dt = BUS.DanhSachCacGoiTiem.layAllDanhSachCacGoiTiem();
            
            foreach (DataRow dr in dt.Rows)
            {
                comboBoxGoiVaccine.Items.Add(dr["MaGoiVaccine"].ToString() + " : " + dr["TenVaccine"].ToString());
            }
                
        }
    }
}
