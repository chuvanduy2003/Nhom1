using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface INhaSXRepository
    {
        public bool Add(NhaSanXuat obj);
        public bool Update(NhaSanXuat obj);
        public bool Delete(NhaSanXuat obj);
        public List<NhaSanXuat> GetAll();
    }
}
