using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.BUS
{
    class KhachHang
    {
        private string makh;
        private string hoTen;
        private string ngaySinh;
        private string gioiTinh;
        private string diaChi;
        private string phone;

        public KhachHang(string hoTen0,string ngaySinh0, string gioiTinh0, string diaChi0, string phone0)
        {
            this.hoTen = hoTen0;
            this.ngaySinh = ngaySinh0;
            this.gioiTinh = gioiTinh0;
            this.diaChi = diaChi0;
            this.phone = phone0;
            int cnt = 1;
            DataTable dt = DAO.KhachHangDB.layAllKhachHang();
            foreach (DataRow row in dt.Rows)
            {
                cnt++;
            }

            this.makh =  "KH" + cnt.ToString();
        }
        public string getMakh()
        {
            return this.makh;
        }
        public string getHoten()
        {
            return this.hoTen;
        }
        public string getNgaySinh()
        {
            return this.ngaySinh;
        }
        public string getGioiTinh()
        {
            return this.gioiTinh;
        }
        public string getDiaChi()
        {
            return this.diaChi;
        }
        public string getPhone()
        {
            return this.phone;
        }
        public bool themKhachHang()
        {
            return DAO.KhachHangDB.themKhachHang(this);
        }
    }
}
