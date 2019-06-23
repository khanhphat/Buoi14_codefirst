using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Buoi14_codefirst.Models
{
    /// <summary>
    /// class nay map 1 1 với DB
    /// DBSet
    /// </summary>
    public class MyDbContext : DbContext
    {
        //Khai báo các thuộc tính bên trong (tương ứng tạo thành các bảng)
        public DbSet<Loai> Loais { get; set; }
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<KhachHang> KhachHangs { get; set; }

        //Hàm tạo có tham số sử dụng chuỗi kết nối ở ConfigureService() trong class StartUp
        public MyDbContext(DbContextOptions opt) : base(opt)
        {

        }
        public MyDbContext() { }
        /// <summary>
        /// chỉ định loại CSDL dùng và chuỗi kết nối
        /// </summary>
        public override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //chỉ định loại CSDL dùng và kết nối 
        }
    }
}
