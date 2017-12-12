using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NhomKhachHangDAL : BaseDAL
    {
        public string getNameNhomKhachHangByMaNhom(int maNhom)
        {
            return data.NhomKhachHangs.Where(x => x.MaNhomKH == maNhom).Select(a => a.TenNhomKH).FirstOrDefault();
        }
        public List<string> getAllNameNhomKhachHang()
        {
            return data.NhomKhachHangs.Select(x => x.TenNhomKH).ToList();
        }
        public int getMaNhomKHByTenNhomKH(string tenNHomKH)
        {
            return data.NhomKhachHangs.Where(x => x.TenNhomKH == tenNHomKH).Select(a => a.MaNhomKH).FirstOrDefault();
        }
    }
}
