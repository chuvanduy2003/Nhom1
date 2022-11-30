using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class HinhThucThanhToanRepository : IHinhThucThanhToanRepository
    {
        Nhom1DbContext _db;
        public HinhThucThanhToanRepository()
        {
            _db = new Nhom1DbContext();
        }


        public bool Add(HinhThucThanhToan obj)
        {
            try
            {
                if (obj == null) return false;
                obj.Id = Guid.NewGuid();
                _db.HinhThucThanhToans.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(HinhThucThanhToan obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.HinhThucThanhToans.FirstOrDefault(x => x.Id == obj.Id);
                _db.HinhThucThanhToans.Remove(temp);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<HinhThucThanhToan> GetAll()
        {
            return _db.HinhThucThanhToans.ToList();
        }

        public bool Update(HinhThucThanhToan obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.HinhThucThanhToans.FirstOrDefault(x => x.Id == obj.Id);
                temp.IdHD = obj.IdHD;
                temp.IdNV = obj.IdNV;
                temp.Ma = obj.Ma;
                temp.LoaiHinhThanhToan = obj.LoaiHinhThanhToan;
                temp.TongTienThanhToan = obj.TongTienThanhToan;
                temp.TrangThai = obj.TrangThai;
                _db.HinhThucThanhToans.Update(temp);
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
