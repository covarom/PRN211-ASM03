
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BillObject.Models;

namespace DataAccess
{
    public class KhachHangDAO
    {
        private static KhachHangDAO instance = null;
        private static readonly object instanceLock = new object();
        private KhachHangDAO() { }
        public static KhachHangDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new KhachHangDAO();
                    }
                    return instance;
                }
            }
        }
        public IEnumerable<KhachHang> GetAllInfor()
        {
            BillManagermentContext context = new BillManagermentContext();
            var kh = from KhachHang in context.KhachHangs select KhachHang;
            return kh.ToList();
        }

        public IEnumerable<KhachHang> GetAllVN()
        {
            BillManagermentContext context = new BillManagermentContext();
            var kh = from KhachHang in context.KhachHangs where KhachHang.QuocTich.Contains("Viet Nam") select KhachHang  ;
            return kh.ToList();
        }

        public IEnumerable<KhachHang> GetAllNN()
        {
            BillManagermentContext context = new BillManagermentContext();
            var kh = from KhachHang in context.KhachHangs where !KhachHang.QuocTich.Contains("Viet Nam") select KhachHang;
            return kh.ToList();
        }
        public void New (KhachHang kh)
        {
            try
            {
                using (var BillManagermentContext = new BillManagermentContext())
                {
                    BillManagermentContext.KhachHangs.Add(kh);
                    BillManagermentContext.SaveChanges();
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Update(KhachHang kh)
        {
            try
            {
                using (var BillManagermentContext = new BillManagermentContext())
                {
                    BillManagermentContext.KhachHangs.Update(kh);
                    BillManagermentContext.SaveChanges();
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public void Delete(KhachHang kh)
        {
            try
            {
                using (var BillManagermentContext = new BillManagermentContext())
                {
                    var khachhangs = BillManagermentContext.KhachHangs.SingleOrDefault(x => x.MaKh == kh.MaKh);
                    BillManagermentContext.KhachHangs.Remove(khachhangs);
                    BillManagermentContext.SaveChanges();
                };
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
