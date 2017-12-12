using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class NhomHangServices
    {
        NhomHangDAL nhomHangDAL;
        public NhomHangServices()
        {
            nhomHangDAL = new NhomHangDAL();
        }
        public string getNameNhomHangByMaNhomHang(int maNhomHang)
        {
            return nhomHangDAL.getNameNhomHangByMaNhomHang(maNhomHang);
        }
        public List<string> loadAllNameNhomHang()
        {
            return nhomHangDAL.loadAllNameNhomHang();
        }
        public int getMaNhomHangByTenNhomHang(string tenNhomHang)
        {
            return nhomHangDAL.getMaNhomHangByTenNhomHang(tenNhomHang);
        }
        public int addNewNhomHang(string tenNhomHang)
        {
            return nhomHangDAL.addNewNhomHang(tenNhomHang);
        }
    }
}
