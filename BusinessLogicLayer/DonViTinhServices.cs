using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class DonViTinhServices
    {
        DonViTinhDAL donViTinhDAL;
        public DonViTinhServices()
        {
            donViTinhDAL = new DonViTinhDAL();
        }
        public string getNameDonViTinhByMaDonVi(int maDonVi)
        {
            return donViTinhDAL.getTenDonViTinhByMaDonViTinh(maDonVi);
        }
        public List<string> loadAllNameDonViTinh()
        {
            return donViTinhDAL.loadAllNameDonViTinh();
        }
        public int addNewDonViTinh(string tenDonViTinh)
        {
            return donViTinhDAL.addNewDonViTinh(tenDonViTinh);
        }
    }
}
