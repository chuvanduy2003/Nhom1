using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class NhaSXRepository : INhaSXRepository
    {
        Nhom1DbContext _db;
        public NhaSXRepository()
        {
            _db = new Nhom1DbContext();
        }

        public bool Add(NhaSanXuat obj)
        {
            try
            {
                if (obj == null) return false;
                obj.Id = Guid.NewGuid();
                _db.NhaSanXuats.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(NhaSanXuat obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.NhaSanXuats.FirstOrDefault(x => x.Id == obj.Id);
                _db.NhaSanXuats.Remove(temp);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<NhaSanXuat> GetAll()
        {
            return _db.NhaSanXuats.ToList();
        }

        public bool Update(NhaSanXuat obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.NhaSanXuats.FirstOrDefault(x => x.Id == obj.Id);
                temp.Ma = obj.Ma;
                temp.NoiSX = obj.NoiSX;
                temp.TrangThai = obj.TrangThai;
                _db.NhaSanXuats.Update(temp);
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

