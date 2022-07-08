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
    public partial class KhachHangNN : Form
    {
        public KhachHangNN()
        {
            InitializeComponent();
        }
        IKhachHangReponsity khachHangReponsity = new KhachHangReponsity();

        BindingSource source;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoadHoaDon(IEnumerable<KhachHang> kh)
        {
            try
            {
                txtMaKH.Text = null;
                txtHoTen.Text = null;
                txtDiaChi.Text = null;
                txtDonGia.Text = null;
                txtQuocTich.Text = null;
                txtSoLuong.Text = null;

                source = new BindingSource();


                source.DataSource = kh.ToList();


                txtMaKH.DataBindings.Clear();
                txtHoTen.DataBindings.Clear();
                txtQuocTich.DataBindings.Clear();
                txtDonGia.DataBindings.Clear();
                txtSoLuong.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();

                txtMaKH.DataBindings.Add("Text", source, "MaKH");
                txtHoTen.DataBindings.Add("Text", source, "HoTenKH");
                txtQuocTich.DataBindings.Add("Text", source, "QuocTich");
                txtDonGia.DataBindings.Add("Text", source, "DonGia");
                txtSoLuong.DataBindings.Add("Text", source, "SoLuong");
                txtDiaChi.DataBindings.Add("Text", source, "DiaChi");

                dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgvKhachHang.DataSource = null;
                dgvKhachHang.DataSource = source;
                if (kh.Count() == 0)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadHoaDon(khachHangReponsity.GetAllNN());
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormInsertKHNN formInsert =new FormInsertKHNN()
            {
                Text = " Thêm khách hàng mới",
                InsertOrUpdate = false,
                khachHangReponsity = khachHangReponsity
            };
            if (formInsert.ShowDialog() == DialogResult.OK)
            {
                LoadHoaDon(khachHangReponsity.GetAllNN());
                source.Position = source.Position - 1;
            }
        }

        public KhachHang getKhachHang()
        {
            KhachHang khachHang = null;
            try
            {
               
                khachHang = new KhachHang()
                {
                    MaKh = int.Parse(txtMaKH.Text),
                    HoTenKh = txtHoTen.Text,
                    SoLuong = int.Parse(txtSoLuong.Text),
                    DonGia = double.Parse(txtDonGia.Text),
                    QuocTich = txtQuocTich.Text,
                    ThanhTien = int.Parse(txtSoLuong.Text) * double.Parse(txtDonGia.Text),
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error: " + ex.Message);
            }
            return khachHang;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            FormInsertKHNN formIS = new FormInsertKHNN()
            {
                Text = "Cập nhật thông tin khách hàng",
                InsertOrUpdate = true,
                kh = getKhachHang(),
                khachHangReponsity = khachHangReponsity
            };
            if (formIS.ShowDialog() == DialogResult.OK)
            {
                LoadHoaDon(khachHangReponsity.GetAllNN());
                source.Position = source.Position - 1;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var khachhang = getKhachHang();
                khachHangReponsity.Delete(khachhang);
                MessageBox.Show("Xoá thành công !");
                LoadHoaDon(khachHangReponsity.GetAllNN());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
