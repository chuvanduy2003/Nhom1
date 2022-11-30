using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class HinhThucThanhToan
    {
        public Guid Id { get; set; }
        public Guid IdHD { get; set; }
        public Guid IdNV { get; set; }
        public string Ma { get; set; }
        public string LoaiHinhThanhToan { get; set; }
        public Double TongTienThanhToan { get; set; }
        public int TrangThai { get; set; }
        
        public HoaDon HoaDon{ get; set; }
    }
}
