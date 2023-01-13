using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace QuanLyTiemChung.DAO
{
    class PhieuDangKyDBContext:DbContext
    {
        public DbSet<PhieuDangKyDB> PhieuDangKyDBs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
