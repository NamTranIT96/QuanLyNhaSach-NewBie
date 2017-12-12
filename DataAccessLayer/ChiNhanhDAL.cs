using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;

namespace DataAccessLayer
{
    public class ChiNhanhDAL : BaseDAL
    {
        public string getTenChiNhanhByMaChiNhanh(int maCN)
        {
            return data.ChiNhanhs.Where(x => x.MaChiNhanh == maCN).FirstOrDefault().TenChiNhanh;
        }
        public string getTenChiNhanhHienTai()
        {
            int maCN = (int)data.ThongTinChiNhanhs.Where(x => x.STT == 1).FirstOrDefault().MaChiNhanh;
            return data.ChiNhanhs.Where(a => a.MaChiNhanh == maCN).FirstOrDefault().TenChiNhanh;
        }
        public string getTenCuaHang()
        {
            return data.ThongTinChiNhanhs.Where(x => x.STT == 1).FirstOrDefault().TenCuaHang;
        }
        public string getDienThoaiCuaHang()
        {
            return data.ThongTinChiNhanhs.Where(x => x.STT == 1).FirstOrDefault().DienThoai;
        }
    }
}
