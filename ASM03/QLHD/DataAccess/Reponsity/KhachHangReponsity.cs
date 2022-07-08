using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillObject.Models;

namespace DataAccess.Reponsity
{
    public class KhachHangReponsity : IKhachHangReponsity
    {
        IEnumerable<KhachHang> IKhachHangReponsity.GetAll() => KhachHangDAO.Instance.GetAllInfor();

        IEnumerable<KhachHang> IKhachHangReponsity.GetAllVN() => KhachHangDAO.Instance.GetAllVN();

        IEnumerable<KhachHang> IKhachHangReponsity.GetAllNN() => KhachHangDAO.Instance.GetAllNN();
        void IKhachHangReponsity.Add(KhachHang kh) => KhachHangDAO.Instance.New(kh);
        void IKhachHangReponsity.Delete(KhachHang kh) => KhachHangDAO.Instance.Delete(kh);

        void IKhachHangReponsity.Update(KhachHang kh) => KhachHangDAO.Instance.Update(kh);
    }
}
