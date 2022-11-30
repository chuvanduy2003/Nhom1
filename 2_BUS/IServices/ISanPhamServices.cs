using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface ISanPhamServices
    {
        string Add(SanPhamViews obj);
        string Update(SanPhamViews obj);
        string Delete(SanPhamViews obj);
        List<SanPhamViews> GetAll();
        List<SanPhamViews> GetAll(string a);
    }
}
