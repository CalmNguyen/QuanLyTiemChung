using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyTiemChung.BUS
{
    class LichRanh
    {
        private string manv;
        private string ngay;
        private string ca;
        public LichRanh(string manv0, string ngay0, string ca0)
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
        public static DataTable layAllLichRanh()
        {
            return DAO.LichRanhDB.layAllLichRanh();
        }
        public static DataTable layLichLamViecThemMaNV(string ma)
        {
            return DAO.LichRanhDB.layLichRanhTheoMaNV(ma);
        }
        public bool themLichRanh()
        {
            return DAO.LichRanhDB.themLichRanh(this);
        }
        public bool xoaLichRanh()
        {
            return DAO.LichRanhDB.xoaLichRanh(this);
        }

    }
}
