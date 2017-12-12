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
    public class ChiNhanhServices
    {
        private ChiNhanhDAL chiNhanhDAL;
        public ChiNhanhServices()
        {
            try
            {
                chiNhanhDAL = new ChiNhanhDAL();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public String getTenVaiTroByMaChiNhanh(int maCN)
        {
            return chiNhanhDAL.getTenChiNhanhByMaChiNhanh(maCN);
        }
        public string getTenChiNhanhHienTai()
        {
            return chiNhanhDAL.getTenChiNhanhHienTai();
        }
        public string getTenCuaHang()
        {
            return chiNhanhDAL.getTenCuaHang();
        }
        public string getDienThoaiCuaHang()
        {
            return chiNhanhDAL.getDienThoaiCuaHang();
        }
    }
}
