using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
namespace BusinessLogicLayer
{
    public class NhomNhaCungCapServices
    {
        private NhomNhaCungCapDAL nhomNhaCungCapDAL;
        public NhomNhaCungCapServices()
        {
            nhomNhaCungCapDAL = new NhomNhaCungCapDAL();
        }
        public string getNameNhomNhaCCByMaNhom(int maNhom)
        {
            return nhomNhaCungCapDAL.getNameNhomByMaNhom(maNhom);
        }
    }
}
