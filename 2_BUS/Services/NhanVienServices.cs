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
    public class NhanVienServices : INhanVienServices
    {
        INhanVienRepository _inhanvienrepository;
        IChucVuRepository _ichucVuRepository;
        public NhanVienServices()
        {
            _inhanvienrepository = new NhanVienRepository();
            _ichucVuRepository = new ChucVuRepository();
        }

        public string Add(NhanVienViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhanVien()
            {
                Id = obj.Id,
                IdCV = obj.IdCV,
                Ma = obj.MaNV,
                Ho = obj.Ho,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                SDT = obj.SDT,
                Email = obj.Email,
                TrangThai = obj.TrangThai,
                MatKhau = obj.MatKhau,
                GhiChu = obj.GhiChu,
                DiaChi = obj.DiaChi,
                
            };
            if (_inhanvienrepository.Add(a)) return "Thành công";
            return "Thất bại";
        }

        public string Delete(NhanVienViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhanVien()
            {
                Id = obj.Id,
                IdCV = obj.IdCV,
                Ma = obj.MaNV,
                Ho = obj.Ho,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                SDT = obj.SDT,
                Email = obj.Email,
                TrangThai = obj.TrangThai,
                MatKhau = obj.MatKhau,
                GhiChu = obj.GhiChu,
                DiaChi = obj.DiaChi,
            };
            if (_inhanvienrepository.Delete(a)) return "Thành công";
            return "Thất bại";
        }

        public List<NhanVienViews> GetAll()
        {
            List<NhanVienViews> lst = new List<NhanVienViews>();
            lst = (from a in _inhanvienrepository.GetAll()
                   join b in _ichucVuRepository.GetAll()
                   on a.IdCV equals b.Id
                   select new NhanVienViews()
                   {
                       Id = a.Id,
                       IdCV = b.Id,
                       MaNV = a.Ma,
                       Ho = a.Ho,
                       TenDem = a.TenDem,
                       Ten = a.Ten,
                       GioiTinh = a.GioiTinh,
                       NgaySinh = a.NgaySinh,
                       SDT = a.SDT,
                       Email = a.Email,
                       MatKhau = a.MatKhau,
                       TrangThai = a.TrangThai,
                       GhiChu = a.GhiChu,
                       TenCV = b.Ten,
                       DiaChi = a.DiaChi,
                   }).ToList();
            return lst;
        }

        public List<NhanVienViews> GetAll(string a)
        {
            if (a == null)
            {
                return GetAll();
            }
            return GetAll().Where(c => c.MaNV.Contains(a)).ToList();
        }

        public string Update(NhanVienViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhanVien()
            {
                Id = obj.Id,
                IdCV = obj.IdCV,
                Ma = obj.MaNV,
                Ho = obj.Ho,
                Ten = obj.Ten,
                TenDem = obj.TenDem,
                GioiTinh = obj.GioiTinh,
                NgaySinh = obj.NgaySinh,
                SDT = obj.SDT,
                Email = obj.Email,
                TrangThai = obj.TrangThai,
                MatKhau = obj.MatKhau,
                GhiChu = obj.GhiChu,
                DiaChi = obj.DiaChi,
            };
            if (_inhanvienrepository.Update(a)) return "Thành công";
            return "Thất bại";
        }
    }
}
