using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class VaiTroDAL : BaseDAL
    {
        public string getTenVaiTroByMaVaiTro(int maVT)
        {
            return data.VaiTroes.Where(x => x.MaVaiTro == maVT).FirstOrDefault().TenVaiTro;
        }
    }
}
