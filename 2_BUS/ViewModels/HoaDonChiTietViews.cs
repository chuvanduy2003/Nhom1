using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class HoaDonChiTietViews
    {
        public Guid Id { get; set; }
        public Guid IdSP { get; set; }
        public Guid IdHD { get; set; }
        public int SoLuong { get; set; }
        public double TienThua { get; set; }
        public double TienGiamGIa { get; set; }
        public string TrangThai { get; set; }
    }
}
