using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class KhachHangRepository : IKhachHangRepository
    {
        Nhom1DbContext _db;
        public KhachHangRepository()
        {
            _db = new Nhom1DbContext();
        }

        public bool Add(KhachHang obj)
        {
            try
            {
                if (obj == null) return false;
                obj.Id = Guid.NewGuid();
                _db.KhachHangs.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(KhachHang obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.KhachHangs.FirstOrDefault(x => x.Id == obj.Id);
                _db.KhachHangs.Remove(temp);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<KhachHang> GetAll()
        {
            return _db.KhachHangs.ToList();
        }

        public bool Update(KhachHang obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.KhachHangs.FirstOrDefault(x => x.Id == obj.Id);
                temp.Ma = obj.Ma;
                temp.HoTen = obj.HoTen;
                temp.SDT = obj.SDT;
                temp.NgaySinh = obj.NgaySinh;
                temp.DiaChi = obj.DiaChi;
                temp.GioiTinh = obj.GioiTinh;
                temp.TrangThai = obj.TrangThai;
                temp.GhiChu = obj.GhiChu;
                _db.KhachHangs.Update(temp);
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
