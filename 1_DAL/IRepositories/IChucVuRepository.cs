using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface IChucVuRepository
    {
        public bool Add(chucvu obj);
        public bool Update(chucvu obj);
        public bool Delete(chucvu obj);
        public List<chucvu> GetAll();
    }
}
