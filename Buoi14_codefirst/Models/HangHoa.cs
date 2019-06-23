using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Buoi14_codefirst.Models
{
    [Table("HangHoa")]
    public class HangHoa
    {
        [Key]
        public int MaHH { get; set; }
        [Required(ErrorMessage ="*")]
        public string TenHH { get; set; }
        public string SoLuong { get; set; }
        public string DonGia { get; set; }
        public string Hinh { get; set; }
        public int MaLoai { get; set; } // khóa ngoại
        [ForeignKey("MaLoai")]
        public Loai Loai { get; set; } //reference đến bảng Loại
    }
}
