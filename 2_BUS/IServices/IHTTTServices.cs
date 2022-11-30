using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface IHTTTServices
    {
        string Add(HinhThucThanhToanViews obj);
        string Update(HinhThucThanhToanViews obj);
        string Delete(HinhThucThanhToanViews obj);
        List<HinhThucThanhToanViews> GetAll();
    }
}
