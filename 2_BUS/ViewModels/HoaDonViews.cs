using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.ViewModels
{
    public class HoaDonViews
    {
        public Guid Id { get; set; }
        public Guid IdKH { get; set; }
        public Guid IdNV { get; set; }
        public string Ma { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public double TongTien { get; set; }
        public string TrangThai { get; set; }
    }
}
