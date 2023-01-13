using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyTiemChung.BUS
{
    class XacNhanThanhToan
    {
        private string MaXNTT;
        private string MaHDTT;
        private int DotThanhToan;
        private float ThanhTien;
        private DateTime NgayThanhToan;
        private DateTime NgayThanhToanTiepTheo;
        private float TongTienChuaThanhToan;

        private float TongTien;
        public XacNhanThanhToan(string MaHDTT0, int DotThanhToan0,float ThanhTien0, DateTime NgayThanhToanTiepTheo0)
        {
            this.MaHDTT = MaHDTT0;
            this.DotThanhToan = DotThanhToan0;
            this.ThanhTien = ThanhTien0;
            this.NgayThanhToanTiepTheo = NgayThanhToanTiepTheo0;
            this.NgayThanhToan = DateTime.Today;

            DataTable data = DAO.HoaDonThanhToanDB.layHDTTTheoMaHDTT(this.MaHDTT);
            this.TongTien = float.Parse(data.Rows[0]["TongTien"].ToString());
            float TongTienDaTT = float.Parse(data.Rows[0]["TongTienDaThanhToan"].ToString());
            this.TongTienChuaThanhToan = TongTien - TongTienDaTT - this.ThanhTien;

            string result = "MAXNTT";
            int increa = 0;
            if (DAO.XacNhanThanhToanDB.GetMaxMaXNTT().Length != 0)
            {
                increa = int.Parse(DAO.XacNhanThanhToanDB.GetMaxMaXNTT().Substring(6));
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
            this.MaXNTT = result;

        }
        public string getMaXNTT()
        {
            return this.MaXNTT;
        }
        public string getMaHDTT()
        {
            return this.MaHDTT;
        }
        public int getDotThanhToan()
        {
            return this.DotThanhToan;
        }
        public float getThanhTien()
        {
            return this.ThanhTien;
        }
        public DateTime getNgayThanhToanTiepTheo()
        {
            return this.NgayThanhToanTiepTheo;
        }
        public DateTime getNgayThanhToan()
        {
            return this.NgayThanhToan;
        }
        public float getTongTienChuaThanhToan()
        {
            return this.TongTienChuaThanhToan;
        }
       
        public bool ThemXNTT()
        {
            return DAO.XacNhanThanhToanDB.ThemXNTT(this) && DAO.HoaDonThanhToanDB.updateHoaDonThanhToan_DaTT(this.MaHDTT, this.TongTien - this.TongTienChuaThanhToan);

        }
    }
}
