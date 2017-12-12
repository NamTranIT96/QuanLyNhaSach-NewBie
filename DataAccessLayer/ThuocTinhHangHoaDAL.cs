using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;
namespace DataAccessLayer
{
    public class ThuocTinhHangHoaDAL:BaseDAL
    {
       public ThuocTinh getThuocTinhByMaThuocTinh(int maThuocTinh)
        {
            return data.ThuocTinhs.Where(x => x.MaThuocTinh == maThuocTinh).FirstOrDefault();
        }
       
    }
}
