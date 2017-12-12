using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class NhomKhachHangServices
    {
        private NhomKhachHangDAL nhomKhachHangDAL;
        public NhomKhachHangServices()
        {
            nhomKhachHangDAL = new NhomKhachHangDAL();
        }
        public string getNameNhomKhachHangByMaNhom(int maNhom)
        {
            return nhomKhachHangDAL.getNameNhomKhachHangByMaNhom(maNhom);
        }
        public List<string> getAllNameNhomKhachHang()
        {
            return nhomKhachHangDAL.getAllNameNhomKhachHang();
        }
    }
}
