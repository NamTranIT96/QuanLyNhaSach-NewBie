using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities.EF;
using System.Windows.Forms;
using System.Data;
using BusinessEntities.Repositories;
using System.ComponentModel;

namespace BusinessLogicLayer
{
    public class VaiTroServices
    {
        private VaiTroDAL vaiTroDAL;

        public VaiTroServices()
        {
            try
            {
                vaiTroDAL = new VaiTroDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public String getTenVaiTroByMaVaiTro(int maVT)
        {
            return vaiTroDAL.getTenVaiTroByMaVaiTro(maVT);
        }
    }
}
