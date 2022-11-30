using _1_DAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.IRepositories
{
    public interface IHinhThucThanhToanRepository
    {
        public bool Add(HinhThucThanhToan obj);
        public bool Update(HinhThucThanhToan obj);
        public bool Delete(HinhThucThanhToan obj);
        public List<HinhThucThanhToan> GetAll();
    }
}
