using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.BUS
{
    class TreEm
    {
        private string makh;
        private string hoTenNguoiGiamHo;
        private string quanHe;
        private string phoneNguoiGiamHo;
        public TreEm(string makh0, string hoTenNguoiGiamHo0, string quanHe0, string phoneNguoiGiamHo0)
        {
            this.makh = makh0;
            this.hoTenNguoiGiamHo = hoTenNguoiGiamHo0;
            this.quanHe = quanHe0;
            this.phoneNguoiGiamHo = phoneNguoiGiamHo0;
        }
        public string getMakh()
        {
            return this.makh;
        }
        public string getHoTenNguoiGiamHo()
        {
            return this.hoTenNguoiGiamHo;
        }
        public string getQuanHe()
        {
            return this.quanHe;
        }
        public string getPhoneNguoiGiamHo()
        {
            return this.phoneNguoiGiamHo;
        }
        public bool themTreEm()
        {
            return DAO.TreEmDB.themTreEm(this);
        }
    }
}
