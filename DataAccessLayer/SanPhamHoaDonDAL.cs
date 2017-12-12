using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;
namespace DataAccessLayer
{
    public class SanPhamHoaDonDAL : BaseDAL
    {
        public bool addNewSanPhamHoaDon(SanPhamHoaDon sanPhamHoaDon)
        {
            try
            {
                data.SanPhamHoaDons.Add(sanPhamHoaDon);
                data.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<SanPhamHoaDon> getSanPhamHoaDonByMaHoaDon(string maHoaDon)
        {
            return data.SanPhamHoaDons.Where(x => x.MaHoaDon == maHoaDon).ToList();
        }
    }
}
