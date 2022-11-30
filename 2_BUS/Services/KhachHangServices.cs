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
    public class KhachHangServices : IKhachHangServices
    {
        IKhachHangRepository _ikhachhangrepository;
        public KhachHangServices()
        {
            _ikhachhangrepository = new KhachHangRepository();
        }
        public string Add(KhachHangViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.MaKH,
                HoTen = obj.HoTen,
                SDT = obj.SDT,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                GioiTinh = obj.GioiTinh,
                TrangThai = obj.TrangThai,
                GhiChu = obj.GhiChu,
            };
            if (_ikhachhangrepository.Add(a)) return "Thành công";
            return "Thất bại";
        }

        public string Delete(KhachHangViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.MaKH,
                HoTen = obj.HoTen,
                SDT = obj.SDT,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                GioiTinh = obj.GioiTinh,
                TrangThai = obj.TrangThai,
                GhiChu = obj.GhiChu,
            };
            if (_ikhachhangrepository.Delete(a)) return "Thành công";
            return "Thất bại";
        }

        public List<KhachHangViews> GetAll()
        {
            List<KhachHangViews> lst = new List<KhachHangViews>();
            lst = (from a in _ikhachhangrepository.GetAll()
                   select new KhachHangViews
                   {
                       Id = a.Id,
                       MaKH = a.Ma,
                       HoTen = a.HoTen,
                       SDT = a.SDT,
                       NgaySinh = a.NgaySinh,
                       DiaChi = a.DiaChi,
                       GioiTinh = a.GioiTinh,
                       TrangThai = a.TrangThai,
                       GhiChu = a.GhiChu,
                   }).ToList();
            return lst;
        }

        public List<KhachHangViews> GetAll(string a)
        {
            if (a == null)
            {
                return GetAll();
            }
            return GetAll().Where(c => c.MaKH.Contains(a)).ToList();
        }

        public string Update(KhachHangViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new KhachHang()
            {
                Id = obj.Id,
                Ma = obj.MaKH,
                HoTen = obj.HoTen,
                SDT = obj.SDT,
                NgaySinh = obj.NgaySinh,
                DiaChi = obj.DiaChi,
                GioiTinh = obj.GioiTinh,
                TrangThai = obj.TrangThai,
                GhiChu = obj.GhiChu,
            };
            if (_ikhachhangrepository.Update(a)) return "Thành công";
            return "Thất bại";
        }
    }
}
