using System;
using System.Collections.Generic;
using System.Text;

namespace _1_DAL.Entities
{
    public class NhaSanXuat
    {
        public Guid Id { get; set; }
        public string Ma { get; set; }
        public string NoiSX { get; set; }
        public int TrangThai { get; set; }
        public ICollection<SanPham> SanPham { get; set; }
    }
}
