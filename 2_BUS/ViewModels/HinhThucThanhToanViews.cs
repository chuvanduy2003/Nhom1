using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class HinhThucThanhToanViews
    {
        public Guid Id { get; set; }
        public Guid IdHD { get; set; }
        public Guid IdNV { get; set; }
        public string Ma { get; set; }
        public string LoaiHinhThucThanhToan { get; set; }
        public double TongTienThanhToan { get; set; }
        public int TrangThai { get; set; }
    }
}
