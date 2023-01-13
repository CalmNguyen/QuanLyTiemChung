using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.BUS
{
    class HoaDonThanhToan
    {
        private string MaHDTT;
        private string MaPDK;
        private DateTime NgayLap;
        private int SoDotThanhToan;
        private DateTime NgayThanhToanTiepTheo;
        private string PhuongThucGuiTien;
        private string LoaiThanhToan;
        private float ThanhTienMoiDot;
        private float TongTien;
        private float TongTienDaThanhToan;
        private string KhachHang;
        public HoaDonThanhToan(string MaPDK0, int SoDotThanhToan0, DateTime NgayThanhToanTiepTheo0, 
                               string PhuongThucGuiTien0, string LoaiThanhToan0, float TongTien0, string KhachHang0)
        {
            this.MaPDK = MaPDK0;
            this.NgayLap = DateTime.Today;
            this.SoDotThanhToan = SoDotThanhToan0;
            this.NgayThanhToanTiepTheo = NgayThanhToanTiepTheo0;
            this.PhuongThucGuiTien = PhuongThucGuiTien0;
            this.LoaiThanhToan = LoaiThanhToan0;
            
            this.TongTien = TongTien0;
            this.TongTienDaThanhToan = 0;
            this.KhachHang = KhachHang0;

            this.ThanhTienMoiDot = this.TongTien/this.SoDotThanhToan;

            string result = "MAHDTT";
            int increa = 0;
            if (DAO.HoaDonThanhToanDB.GetMaxMaHDTT().Length != 0)
            {
                increa = int.Parse(DAO.HoaDonThanhToanDB.GetMaxMaHDTT().Substring(6));
            }
            increa++;
            if (increa.ToString().Length < 4)
            {
                for (int i = 0; i < 4 - increa.ToString().Length; i++)
                {
                    result += "0";
                }
                result += increa.ToString();
            }
            this.MaHDTT = result;

        }
        public string getMaHDTT()
        {
            return this.MaHDTT;
        }
        public string getMaPDK()
        {
            return this.MaPDK;
        }
        public DateTime getNgayLap()
        {
            return this.NgayLap;
        }
        public int getSoDotThanhToan()
        {
            return this.SoDotThanhToan;
        }
        public DateTime getNgayThanhToanTiepTheo()
        {
            return this.NgayThanhToanTiepTheo;
        }
        public string getPhuongThucGuiTien()
        {
            return this.PhuongThucGuiTien;
        }
        public string getLoaiThanhToan()
        {
            return this.LoaiThanhToan;
        }
        public float getThanhTienMoiDot()
        {
            return this.ThanhTienMoiDot;
        }
        public float getTongTien()
        {
            return this.TongTien;
        }
        public float getTongTienDaThanhToan()
        {
            return this.TongTienDaThanhToan;
        }
        public string getKhachHang()
        {
            return this.KhachHang;
        }
        public bool ThemHDTT()
        {
            return DAO.HoaDonThanhToanDB.ThemHDTT(this);
        }
    }
}
