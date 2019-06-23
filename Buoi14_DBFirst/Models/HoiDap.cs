﻿using System;
using System.Collections.Generic;

namespace Buoi14_DBFirst.Models
{
    public partial class HoiDap
    {
        public int MaHd { get; set; }
        public string CauHoi { get; set; }
        public string TraLoi { get; set; }
        public DateTime NgayDua { get; set; }
        public string MaNv { get; set; }

        public NhanVien MaNvNavigation { get; set; }
    }
}
