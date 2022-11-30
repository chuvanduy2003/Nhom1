using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class HoaDon
    {
        public Guid Id { get; set; }
        public Guid IdKH { get; set; }
        public Guid IdNV { get; set; }
        public string MaHD { get; set; }
        //public string MaNV { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThanhToan { get; set; }
        public double TongTien { get; set; }
        //public int SoDiemSD { get; set; }
        //public int SoTienQuyDoi { get; set; }
        public int TrangThai { get; set; }
        public  ICollection<HoaDonChiTiet> HoaDonChiTiet { get; set; }
        public ICollection<HinhThucThanhToan> HinhThucThanhToan { get; set; }
        public NhanVien NhanVien { get; set; }
        public KhachHang KhachHang { get; set; }
    }
}
