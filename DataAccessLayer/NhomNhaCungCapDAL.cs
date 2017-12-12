using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class NhomNhaCungCapDAL : BaseDAL
    {
        public string getNameNhomByMaNhom(int maNhom)
        {
            return data.NhomNhaCungCaps.Where(x => x.MaNhomNhaCC == maNhom).Select(a => a.TenNhomNhaCC).FirstOrDefault().ToString();
        }

    }
}
