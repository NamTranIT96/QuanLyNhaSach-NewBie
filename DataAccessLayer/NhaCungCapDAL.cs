using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;
namespace DataAccessLayer
{
    public class NhaCungCapDAL : BaseDAL
    {
        public List<string> getAllNameNhaCungCap()
        {
            return data.NhaCungCaps.Select(x => x.TenNhaCungCap).ToList();
        }

        public List<NhaCungCap> getAllNhaCungCap()
        {
            return data.NhaCungCaps.ToList();
        }
        public NhaCungCap getNhaCCByMaNhaCungCap(string maNhaCC)
        {
            return data.NhaCungCaps.Where(x => x.MaNhaCungCap == maNhaCC).FirstOrDefault();
        }
        public bool setPathForLogo(string maNhaCC, string path)
        {
            NhaCungCap temp = data.NhaCungCaps.Where(x => x.MaNhaCungCap == maNhaCC).FirstOrDefault();
            if (temp != null)
            {
                try
                {
                    temp.Logo = path;
                    data.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
            return false;
        }
    }
}
