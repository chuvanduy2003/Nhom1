using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class SanPhamViews
    {
        public Guid Id { get; set; }
        public Guid IdNSX { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public float GiaNhap { get; set; }
        public float GiaBan { get; set; }
        public int SoLuongTon { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public string NoiSX { get; set; }
    }
}
