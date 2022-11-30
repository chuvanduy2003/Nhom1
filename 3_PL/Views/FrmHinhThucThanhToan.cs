using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _3_PL.Views
{
    public partial class FrmHinhThucThanhToan : Form
    {
        IHTTTServices _hTTTServices;

        private Guid _id;
        public FrmHinhThucThanhToan()
        {
            InitializeComponent();
            _hTTTServices = new HTTTServices();
            LoadData();
        }
        private void LoadData()
        {
            int stt = 1;
            dtg_hienthi.ColumnCount = 6;
            dtg_hienthi.Columns[0].Name = "STT";
            dtg_hienthi.Columns[1].Name = "ID";
            dtg_hienthi.Columns[2].Name = "MÃ";
            dtg_hienthi.Columns[3].Name = "LOẠI HÌNH THANH TOÁN";
            dtg_hienthi.Columns[4].Name = "TỔNG TIỀN";
            dtg_hienthi.Columns[5].Name = "TRẠNG THÁI";
            dtg_hienthi.Rows.Clear();
            foreach (var item in _hTTTServices.GetAll())
            {
                dtg_hienthi.Rows.Add(stt++, item.Id, item.Ma, item.LoaiHinhThucThanhToan,item.TongTienThanhToan,item.TrangThai==1?"Hoạt động":"Không hoặt động");
            }
        }
        public HinhThucThanhToanViews GetData()
        {
            HinhThucThanhToanViews httt = new HinhThucThanhToanViews()
            {
                Id=Guid.Empty,
                IdHD=Guid.Empty,
                IdNV=Guid.Empty,
                Ma = txt_ma.Text,
                LoaiHinhThucThanhToan = txt_loaihinh.Text,
                TongTienThanhToan = double.Parse( txt_tongtien.Text),
                TrangThai = Convert.ToInt32(rbn_hoatdong.Checked),
            };
            return httt;
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            MessageBox.Show(_hTTTServices.Add(GetData()));
            LoadData();
        }

        private void btn_sua_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_hTTTServices.Update(temp));
            LoadData();
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            var temp = GetData();
            temp.Id = _id;
            MessageBox.Show(_hTTTServices.Update(temp));
            LoadData();
        }

        private void dtg_hienthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            _id = Guid.Parse(dtg_hienthi.CurrentRow.Cells[1].Value.ToString());
            var temp = _hTTTServices.GetAll().FirstOrDefault(c => c.Id == _id);
            txt_ma.Text = temp.Ma;
            txt_loaihinh.Text = temp.LoaiHinhThucThanhToan;
            txt_tongtien.Text = Convert.ToString(temp.TongTienThanhToan);
            if (temp.TrangThai == 1)
            {
                rbn_hoatdong.Checked = true;
                return;
            }
            rbn_khonghd.Checked = true;
        }
    }
}
