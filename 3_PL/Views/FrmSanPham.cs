﻿using System;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace _3_PL.Views
{

    public partial class FrmSanPham : Form
    {
        ISanPhamServices _sanPhamServices;
        INhaSXServices _inhaSXServices;
        private Guid _id;
        public FrmSanPham()
        {
            InitializeComponent();
            _sanPhamServices = new SanPhamServices();
            _inhaSXServices = new NhaSXServices();
            LoadNhaSX();
            LoadData();
        }
        public void LoadNhaSX()
        {
            foreach (var item in _inhaSXServices.GetAll())
            {
                cbb_noisx.Items.Add(item.NoiSX);
            }
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 10;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[1].Visible = false;
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "TÊN SẢN PHẨM";
            dtg_hienthi.Columns[4].Name = "GIÁ NHẬP";
            dtg_hienthi.Columns[5].Name = "GIÁ BÁN";
            dtg_hienthi.Columns[6].Name = "SỐ LƯỢNG TỒN";
            dtg_hienthi.Columns[7].Name = "NƠI SẢN XUẤT";
            dtg_hienthi.Columns[8].Name = "TRẠNG THÁI";
            dtg_hienthi.Columns[9].Name = "MÔ TẢ";
            dtg_hienthi.Rows.Clear();
            foreach (var item in _sanPhamServices.GetAll())
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.MaSP, item.TenSP, item.GiaNhap, item.GiaBan, item.SoLuongTon, item.NoiSX, item.TrangThai == 1 ? "Còn hàng" : "Hết hàng", item.MoTa);
            }
        }
        private void TimKiem(string a)
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 10;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[1].Visible = false;
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "TÊN SẢN PHẨM";
            dtg_hienthi.Columns[4].Name = "GIÁ NHẬP";
            dtg_hienthi.Columns[5].Name = "GIÁ BÁN";
            dtg_hienthi.Columns[6].Name = "SỐ LƯỢNG TỒN";
            dtg_hienthi.Columns[7].Name = "NƠI SẢN XUẤT";
            dtg_hienthi.Columns[8].Name = "TRẠNG THÁI";
            dtg_hienthi.Columns[9].Name = "MÔ TẢ";
            dtg_hienthi.Rows.Clear();
            foreach (var item in _sanPhamServices.GetAll(a))
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.MaSP, item.TenSP, item.GiaNhap, item.GiaBan, item.SoLuongTon, item.NoiSX, item.TrangThai == 1 ? "Còn hàng" : "Hết hàng", item.MoTa);
            }
        }
        public SanPhamViews GetData()
        {
            SanPhamViews sp = new SanPhamViews()
            {
                Id = Guid.Empty,
                IdNSX = _inhaSXServices.GetAll().FirstOrDefault(c => c.NoiSX == cbb_noisx.Text).Id,
                MaSP = txt_ma.Text,
                TenSP = txt_ten.Text,
                GiaNhap = float.Parse(txt_gianhap.Text),
                GiaBan = float.Parse(txt_giaban.Text),
                SoLuongTon = Convert.ToInt32(txt_soluongton.Text),
                MoTa = txt_mota.Text,
                TrangThai = Convert.ToInt32(rbn_conhang.Checked),
                NoiSX = cbb_noisx.Text,
            };
            return sp;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            FrmBarCode frmBarCode = new FrmBarCode();
            frmBarCode.ShowDialog();
            txt_ma.Text = frmBarCode.txtBar_Code;
            MessageBox.Show(_sanPhamServices.Add(GetData()));
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_sanPhamServices.Update(temp));
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_sanPhamServices.Delete(temp));
            LoadData();
        }

        private void btn_timkiem_Click(object sender, EventArgs e)
        {
            TimKiem(txt_timkiem.Text);
        }

        private void dtg_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_hienthi.CurrentRow.Cells[1].Value.ToString());
            var temp = _sanPhamServices.GetAll().FirstOrDefault(c => c.Id == _id);
            txt_ma.Text = temp.MaSP;
            txt_ten.Text = temp.TenSP;
            txt_gianhap.Text = Convert.ToString(temp.GiaNhap);
            txt_giaban.Text = Convert.ToString(temp.GiaBan);
            txt_soluongton.Text = Convert.ToString(temp.SoLuongTon);
            txt_mota.Text = temp.MoTa;
            cbb_noisx.SelectedIndex = cbb_noisx.FindStringExact(_inhaSXServices.GetAll().FirstOrDefault(c => c.Id == temp.IdNSX).NoiSX.ToString());
            if (temp.TrangThai == 1)
            {
                rbn_conhang.Checked = true;
                return;
            }
            rbn_hethang.Checked = true;
        }
    }
}
