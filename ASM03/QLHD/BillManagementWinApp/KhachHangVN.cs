using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using DataAccess.Reponsity;
using BillObject.Models;

namespace QLHD.BillManagementWinApp
{
    public partial class KhachHangVN : Form
    {
        public KhachHangVN()
        {
            InitializeComponent();
        }
        IKhachHangReponsity khachHangReponsity = new KhachHangReponsity();

        BindingSource source;

        public KhachHang khachhangInfor { get; set; }

        private void KhachHangVN_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtMaKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDonGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtThanhTien_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoaiKH_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDinhMuc_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadHoaDon(khachHangReponsity.GetAllVN());
        }

        private void LoadHoaDon(IEnumerable<KhachHang> kh)
        {
            try
            {
                txtMaKH.Text = null;
                txtHoTen.Text = null;
                txtDinhMuc.Text = null;
                txtDonGia.Text = null;
                txtLoaiKH.Text = null;
                txtSoLuong.Text = null;
                txtDiaChi.Text = null;

                source = new BindingSource();

                
                source.DataSource = kh.ToList();

              
                txtMaKH.DataBindings.Clear();
                txtHoTen.DataBindings.Clear();
                txtDinhMuc.DataBindings.Clear();
                txtDonGia.DataBindings.Clear();
                txtLoaiKH.DataBindings.Clear();
                txtSoLuong.DataBindings.Clear();
                txtDiaChi.DataBindings.Clear();

                txtMaKH.DataBindings.Add("Text", source, "MaKH");
                txtHoTen.DataBindings.Add("Text", source, "HoTenKH");
                txtDinhMuc.DataBindings.Add("Text", source, "DinhMuc");
                txtDonGia.DataBindings.Add("Text", source, "DinhMuc");
                txtSoLuong.DataBindings.Add("Text", source, "SoLuong");
                txtLoaiKH.DataBindings.Add("Text", source, "LoaiKH");
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


        private void btnInsert_Click(object sender, EventArgs e)
        {
            FormInsertKHVN formIS = new FormInsertKHVN()
            {
                Text = " Thêm khách hàng mới",
                InsertOrUpdate = false,
                khachHangReponsity = khachHangReponsity
            };
            if(formIS.ShowDialog() == DialogResult.OK)
            {
                LoadHoaDon(khachHangReponsity.GetAllVN());
                source.Position = source.Position - 1;
            }
        }
        public KhachHang getKhachHang()
        {
            KhachHang khachHang = null;
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

                khachHang = new KhachHang()
                {
                    MaKh = int.Parse(txtMaKH.Text),
                    HoTenKh = txtHoTen.Text,
                    DinhMuc = int.Parse(txtDinhMuc.Text),
                    SoLuong = int.Parse(txtSoLuong.Text),
                    DonGia = double.Parse(txtDonGia.Text),
                    LoaiKh = txtLoaiKH.Text,
                    QuocTich = "Viet Nam",
                    ThanhTien = kq,
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
            FormInsertKHVN formIS = new FormInsertKHVN()
            {
                Text = "Cập nhật thông tin khách hàng",
                InsertOrUpdate = true,
                kh = getKhachHang(),
                khachHangReponsity = khachHangReponsity
            };
            if (formIS.ShowDialog() == DialogResult.OK)
            {
                LoadHoaDon(khachHangReponsity.GetAllVN());
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
                LoadHoaDon(khachHangReponsity.GetAllVN());
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
