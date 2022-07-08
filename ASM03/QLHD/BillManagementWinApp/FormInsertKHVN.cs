using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess.Reponsity;
using BillObject.Models;

namespace QLHD.BillManagementWinApp
{
    public partial class FormInsertKHVN : Form
    {
        public FormInsertKHVN()
        {
            InitializeComponent();
        }
        public IKhachHangReponsity khachHangReponsity = new KhachHangReponsity();
        public bool InsertOrUpdate { get; set; }

        public KhachHang kh { get; set; }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                double kq = 0;
                if (int.Parse(txtSoLuong.Text) <= int.Parse(txtDinhMuc.Text))
                {
                    kq = (double)((int.Parse(txtSoLuong.Text)) * (int.Parse(txtDonGia.Text)));
                }
                else
                {
                    kq = (double)((int.Parse(txtDinhMuc.Text)) * (int.Parse(txtDonGia.Text)) +
                        (double)(((int.Parse(txtSoLuong.Text)) - (int.Parse(txtDinhMuc.Text))) * (int.Parse(txtDonGia.Text)) * 2.5));
                }

                var khachhangmoi = new KhachHang()
                {
                    MaKh = int.Parse(txtMaKH.Text),
                    HoTenKh = txtHoTen.Text,
                    DinhMuc = int.Parse(txtDinhMuc.Text),
                    SoLuong = int.Parse(txtSoLuong.Text),
                    DonGia = double.Parse(txtDonGia.Text),
                    LoaiKh = txtLoaiKH.Text,
                    QuocTich = "Viet Nam",
                    ThanhTien = kq,
                    DiaChi = txtDiaChi.Text,
            };
                if (InsertOrUpdate == false)
                {
                    khachHangReponsity.Add(khachhangmoi);
                    MessageBox.Show("Thêm khách hàng thành công !!");
                }
                else
                {
                    khachHangReponsity.Update(khachhangmoi);
                    MessageBox.Show("Cập nhật khách hàng thành công !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Tạo mới hoá đơn !" : "Cập nhật hoá đơn !");
            }
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main main = new Main();
            main.ShowDialog();
        }

        private void txtLoaiKH_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
