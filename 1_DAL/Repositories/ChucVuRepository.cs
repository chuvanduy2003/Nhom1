using _1_DAL.EF;
using _1_DAL.Entities;
using _1_DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_DAL.Repositories
{
    public class ChucVuRepository : IChucVuRepository
    {
        Nhom1DbContext _db;
        private List<chucvu> _chucVuList;

        public ChucVuRepository()
        {
            _db = new Nhom1DbContext();
            _chucVuList = new List<chucvu>();
        }

        public bool Add(chucvu obj)
        {

            try
            {
                if (obj == null) return false;
                obj.Id = Guid.NewGuid();
                _db.ChucVus.Add(obj);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(chucvu obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.ChucVus.FirstOrDefault(x => x.Id == obj.Id);
                _db.ChucVus.Remove(temp);
                _db.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<chucvu> GetAll()
        {
            _chucVuList = _db.ChucVus.ToList();
            return _chucVuList;
        }

        public bool Update(chucvu obj)
        {
            try
            {
                if (obj == null) return false;
                var temp = _db.ChucVus.FirstOrDefault(c => c.Id == obj.Id);
                temp.Ma = obj.Ma;
                temp.Ten = obj.Ten;
                _db.ChucVus.Update(temp);
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
