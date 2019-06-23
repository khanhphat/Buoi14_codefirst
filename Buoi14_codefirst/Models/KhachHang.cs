using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Buoi14_codefirst.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public int MaKH { get; set; }
        [Display(Name = "Tên khách hàng")]
        [MaxLength(50, ErrorMessage = "Tối đa 50 kí tự")]
        [Required(ErrorMessage = "*")]
        public string HoTen { get; set; }
        [Display(Name = "Điện thoại")]
        public string DienThoai { get; set; }
        [Display(Name = "Email")]
        [MaxLength(50)]
        public string Email { get; set; }
    }
}
