using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class HoaDonRepository : IHoaDonRepository
    {
        Nhom1DbContext _db;
        public HoaDonRepository()
        {
            _db = new Nhom1DbContext();
        }

        public bool Add(HoaDon obj)
        {
            try
            {
                if (obj == null) return false;
                obj.Id = Guid.NewGuid();
                _db.HoaDons.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(HoaDon obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.HoaDons.FirstOrDefault(x => x.Id == obj.Id);
                _db.HoaDons.Remove(temp);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<HoaDon> GetAll()
        {
            return _db.HoaDons.ToList();
        }

        public bool Update(HoaDon obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.HoaDons.FirstOrDefault(x => x.Id == obj.Id);
                temp.IdKH = obj.IdKH;
                temp.IdNV = obj.IdNV;
                temp.MaHD = obj.MaHD;
                temp.NgayTao = obj.NgayTao;
                temp.NgayThanhToan = obj.NgayThanhToan;
                temp.TongTien = obj.TongTien;
                temp.TrangThai = obj.TrangThai;
                _db.HoaDons.Update(temp);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
