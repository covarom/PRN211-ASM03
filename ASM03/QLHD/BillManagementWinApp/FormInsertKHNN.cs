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
    public partial class FormInsertKHNN : Form
    {
        public FormInsertKHNN()
        {
            InitializeComponent();
        }

        public IKhachHangReponsity khachHangReponsity = new KhachHangReponsity();
        public bool InsertOrUpdate { get; set; }

        public KhachHang kh { get; set; }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
               
                var khachhangmoi = new KhachHang()
                {
                    MaKh = int.Parse(txtMaKH.Text),
                    HoTenKh = txtHoTen.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    DonGia = double.Parse(txtDonGia.Text),
                    QuocTich = txtQuocTich.Text,
                    ThanhTien = int.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text),
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
        }
    }
}
