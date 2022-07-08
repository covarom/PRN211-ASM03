using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillObject.Models;

namespace DataAccess.Reponsity
{
    public interface IKhachHangReponsity
    {
        IEnumerable<KhachHang> GetAll();

        IEnumerable<KhachHang> GetAllVN();

        IEnumerable<KhachHang> GetAllNN();
        void Add(KhachHang kh);
        void Update(KhachHang kh);
        void Delete(KhachHang kh);
    }
}
