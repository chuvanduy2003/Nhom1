using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace _2_BUS.IServices
{
    public interface INhaSXServices
    {
        string Add(NhaSXViews obj);
        string Update(NhaSXViews obj);
        string Delete(NhaSXViews obj);
        List<NhaSXViews> GetAll();
    }
}
