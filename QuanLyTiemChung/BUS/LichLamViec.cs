using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.BUS
{
    class LichLamViec
    {
        private string manv;
        private string ngay;
        private string ca;

        public LichLamViec(string manv0, string ngay0, string ca0)
        {
            this.manv = manv0;
            this.ngay = ngay0;
            this.ca = ca0;
        }
        public string getManv()
        {
            return this.manv;
        }
        public string getNgay()
        {
            return this.ngay;
        }
        public string getCa()
        {
            return this.ca;
        }
        public static DataTable layAllLichLamViec()
        {
            return DAO.LichLamViecDB.layAllLichLamViec();
        }
        public static DataTable layLichLamViecTheoMaNV(string ma)
        {
            return DAO.LichLamViecDB.layLichLamViecTheoMaNV(ma);
        }
        public bool themLichLamViec()
        {
            return DAO.LichLamViecDB.themLichLamViec(this);
        }
    }
}
