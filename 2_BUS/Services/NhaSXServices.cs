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
    public class NhaSXServices : INhaSXServices
    {
        INhaSXRepository _iNhaSXRepository;
        public NhaSXServices()
        {
            _iNhaSXRepository = new NhaSXRepository();
        }

        public string Add(NhaSXViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhaSanXuat()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                NoiSX = obj.NoiSX,
                TrangThai = obj.TrangThai,
            };
            if (_iNhaSXRepository.Add(a)) return "Thành Công";
            return "Thất bại";
        }

        public string Delete(NhaSXViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhaSanXuat()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                NoiSX = obj.NoiSX,
                TrangThai = obj.TrangThai,
            };
            if (_iNhaSXRepository.Delete(a)) return "Thành Công";
            return "Thất bại";
        }

        public List<NhaSXViews> GetAll()
        {
            List<NhaSXViews> lst = new List<NhaSXViews>();
            lst = (from a in _iNhaSXRepository.GetAll()
                   select new NhaSXViews
                   {
                       Id = a.Id,
                       Ma = a.Ma,
                       NoiSX= a.NoiSX,
                       TrangThai = a.TrangThai,
                   }).ToList();
            return lst;
        }

        public string Update(NhaSXViews obj)
        {
            if (obj == null) return "Thất bại";
            var a = new NhaSanXuat()
            {
                Id = obj.Id,
                Ma = obj.Ma,
                NoiSX = obj.NoiSX,
                TrangThai = obj.TrangThai,
            };
            if (_iNhaSXRepository.Update(a)) return "Thành Công";
            return "Thất bại";
        }
    }
}
