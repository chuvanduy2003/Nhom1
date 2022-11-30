﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public Guid IdNSX { get; set; }
        public string Ten { get; set; }
        public string Ma { get; set; }
        public int SoLuongTon { get; set; }
        public float GiaNhap { get; set; }
        public float GiaBan { get; set; }
        public string MoTa { get; set; }
        public int TrangThai { get; set; }
        public NhaSanXuat NSX { get; set; }
        public ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }

    }
}
