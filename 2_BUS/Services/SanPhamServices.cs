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
    public class SanPhamServices : ISanPhamServices
    {
        ISanPhamRepository _iSanPhamRepository;
        INhaSXRepository _iNhaSXRepository;
        public SanPhamServices()
        {
            _iSanPhamRepository = new SanPhamRepository();
            _iNhaSXRepository = new NhaSXRepository();
        }
        public string Add(SanPhamViews obj)
        {
            if (obj == null) return "Thất bại";

            var a = new SanPham()
            {

                Id = obj.Id,
                IdNSX = obj.IdNSX,
                Ma = obj.MaSP,
                Ten = obj.TenSP,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                SoLuongTon = obj.SoLuongTon,
                MoTa = obj.MoTa,
                TrangThai = obj.TrangThai,
                
            };
            if (_iSanPhamRepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(SanPhamViews obj)
        {
            if (obj == null) return "Thất bại";

            var a = new SanPham()
            {

                Id = obj.Id,
                IdNSX = obj.IdNSX,
                Ma = obj.MaSP,
                Ten = obj.TenSP,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                SoLuongTon = obj.SoLuongTon,
                MoTa = obj.MoTa,
                TrangThai = obj.TrangThai,

            };
            if (_iSanPhamRepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        public List<SanPhamViews> GetAll()
        {
            List<SanPhamViews> lst = new List<SanPhamViews>();
            lst = (from a in _iSanPhamRepository.GetAll()
                   join b in _iNhaSXRepository.GetAll()
                   on a.IdNSX equals b.Id
                   select new SanPhamViews
                   {
                       Id=a.Id,
                       IdNSX=b.Id,
                       MaSP = a.Ma,
                       TenSP = a.Ten,
                       GiaNhap = a.GiaNhap,
                       GiaBan = a.GiaBan,
                       SoLuongTon = a.SoLuongTon,
                       MoTa = a.MoTa,
                       TrangThai = a.TrangThai,
                       NoiSX = b.NoiSX,
                   }).ToList();
            return lst;
        }

        public List<SanPhamViews> GetAll(string a)
        {
            if (a == null)
            {
                return GetAll();
            }
            return GetAll().Where(c => c.MaSP.Contains(a)).ToList();
        }

        public string Update(SanPhamViews obj)
        {
            if (obj == null) return "Thất bại";

            var a = new SanPham()
            {

                Id = obj.Id,
                IdNSX = obj.IdNSX,
                Ma = obj.MaSP,
                Ten = obj.TenSP,
                GiaNhap = obj.GiaNhap,
                GiaBan = obj.GiaBan,
                SoLuongTon = obj.SoLuongTon,
                MoTa = obj.MoTa,
                TrangThai = obj.TrangThai,

            };
            if (_iSanPhamRepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
    }
}
