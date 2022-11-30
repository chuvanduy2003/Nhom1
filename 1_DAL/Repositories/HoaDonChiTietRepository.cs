using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class HoaDonChiTietRepository : IHoaDonChiTietRepository
    {
        Nhom1DbContext _db;
        public HoaDonChiTietRepository()
        {
            _db = new Nhom1DbContext();
        }

        public bool Add(HoaDonChiTiet obj)
        {
            try
            {
                if (obj == null) return false;
                obj.Id = Guid.NewGuid();
                _db.HoaDonChiTiets.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(HoaDonChiTiet obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.HoaDonChiTiets.FirstOrDefault(x => x.Id == obj.Id);
                _db.HoaDonChiTiets.Remove(temp);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<HoaDonChiTiet> GetAll()
        {
            return _db.HoaDonChiTiets.ToList();
        }

        public bool Update(HoaDonChiTiet obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.HoaDonChiTiets.FirstOrDefault(x => x.Id == obj.Id);
                temp.IdSP = obj.IdSP;
                temp.IdHD = obj.IdHD;
                temp.SoLuong = obj.SoLuong;
                temp.TrangThai = obj.TrangThai;
                _db.HoaDonChiTiets.Update(temp);
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
