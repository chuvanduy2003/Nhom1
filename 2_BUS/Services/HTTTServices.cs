using _1_DAL.Entities;
using _1_DAL.IRepositories;
using _1_DAL.Repositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2_BUS.Services
{
    public class HTTTServices : IHTTTServices
    {
        IHinhThucThanhToanRepository _ihinhthucthanhtoanrepository;
        IHoaDonRepository _ihoadonrepository;
        INhanVienRepository _inhanvienrepository;
        public HTTTServices()
        {
            _ihinhthucthanhtoanrepository = new HinhThucThanhToanRepository();
            _ihoadonrepository = new HoaDonRepository();
            _inhanvienrepository = new NhanVienRepository();
        }
        public string Add(HinhThucThanhToanViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new HinhThucThanhToan()
            {
                Id = obj.Id,
                IdHD = obj.IdHD,
                IdNV = obj.IdNV,
                Ma = obj.Ma,
                LoaiHinhThanhToan = obj.LoaiHinhThucThanhToan,
                TongTienThanhToan = obj.TongTienThanhToan,
                TrangThai = obj.TrangThai,
            };
            if (_ihinhthucthanhtoanrepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(HinhThucThanhToanViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new HinhThucThanhToan()
            {
                Id = obj.Id,
                IdHD = obj.IdHD,
                IdNV = obj.IdNV,
                Ma = obj.Ma,
                LoaiHinhThanhToan = obj.LoaiHinhThucThanhToan,
                TongTienThanhToan = obj.TongTienThanhToan,
                TrangThai = obj.TrangThai,
            };
            if (_ihinhthucthanhtoanrepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        public List<HinhThucThanhToanViews> GetAll()
        {

            List<HinhThucThanhToanViews> lst = new List<HinhThucThanhToanViews>();
            lst = (from a in _ihinhthucthanhtoanrepository.GetAll()
                   join b in _ihoadonrepository.GetAll() on a.IdHD equals b.Id
                   select new HinhThucThanhToanViews
                   {
                       Id = a.Id,
                       IdHD = a.IdHD,
                       IdNV = a.IdNV,
                       Ma = a.Ma,
                       LoaiHinhThucThanhToan = a.LoaiHinhThanhToan,
                       TongTienThanhToan = a.TongTienThanhToan,
                       TrangThai = a.TrangThai,
                   }).ToList();
            return lst;
        }

        public string Update(HinhThucThanhToanViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new HinhThucThanhToan()
            {
                Id = obj.Id,
                IdHD = obj.IdHD,
                IdNV = obj.IdNV,
                Ma = obj.Ma,
                LoaiHinhThanhToan = obj.LoaiHinhThucThanhToan,
                TongTienThanhToan = obj.TongTienThanhToan,
                TrangThai = obj.TrangThai,
            };
            if (_ihinhthucthanhtoanrepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
    }
}
