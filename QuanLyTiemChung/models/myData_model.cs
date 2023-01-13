using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Migrations;
/*using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;*/
namespace QuanLyTiemChung.models
{
    public class myData_model : DbContext
    {
        public DbSet<DanhSachCacGoiTiem> DanhSachCacGoiTiems { set; get; }        // bảng article

        // chuỗi kết nối với tên db sẽ làm  việc đặt là webdb
        public const string ConnectString = @"Data Source=DESKTOP-DT03IGN;Initial Catalog=QuanLytiemChung;Integrated Security=True";
        /*protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectString);
            optionsBuilder.UseLoggerFactory(GetLoggerFactory());       // bật logger
        }

        private ILoggerFactory GetLoggerFactory()
        {
            IServiceCollection serviceCollection = new ServiceCollection();
            serviceCollection.AddLogging(builder =>
                    builder.AddConsole()
                           .AddFilter(DbLoggerCategory.Database.Command.Name,
                                    LogLevel.Information));
            return serviceCollection.BuildServiceProvider()
                    .GetService<ILoggerFactory>();
        }*/
    }
    }
