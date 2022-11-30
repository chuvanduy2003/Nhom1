using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class HoaDonChiTiet
    {
        public Guid Id { get; set; }
        public Guid IdSP { get; set; }
        public Guid IdHD { get; set; }
        public double DonGia { get; set; }
        public int SoLuong { get; set; }
        public int TrangThai { get; set; }
        public HoaDon HoaDon { get; set; }
        public SanPham SanPham { get; set; }
    }
}
