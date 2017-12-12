using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;
namespace DataAccessLayer
{
    public class HangHoaDAL : BaseDAL
    {
        /// <summary>
        /// Lấy thông tin tất cả các hàng hoá
        /// </summary>
        /// <returns></returns>
        public List<HangHoa> getAllHangHoa()
        {
            return data.HangHoas.ToList();
        }
        public HangHoa getHangHoaByTenHang(string tenHang)
        {
            HangHoa temp = data.HangHoas.Where(a => a.TenHang.Contains(tenHang)).FirstOrDefault();
            return temp;
        }

        public HangHoa getHangHoaByMaHangHoa(string maHangHoa)
        {
            return data.HangHoas.Where(a => a.MaHangHoa == maHangHoa).FirstOrDefault();
        }
        public bool setPathForImageHangHoa(string maHangHoa, string path)
        {
            HangHoa temp = data.HangHoas.Where(x => x.MaHangHoa == maHangHoa).FirstOrDefault();
            if (temp != null)
            {
                try
                {
                    temp.AnhDaiDien = path;
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
        public bool editInforHangHoa(HangHoa hanghoa)
        {
            HangHoa temp = data.HangHoas.Where(x => x.MaHangHoa == hanghoa.MaHangHoa).FirstOrDefault();
            if(temp!=null)
            {
                temp.TenHang = hanghoa.TenHang;
                temp.NhomHang = hanghoa.NhomHang;
                temp.GiaBan = hanghoa.GiaBan;
                temp.GiaVon = hanghoa.GiaVon;
                temp.TonKho = hanghoa.TonKho;
                temp.DonViTinh = hanghoa.DonViTinh;
                temp.MaBarCode = hanghoa.MaBarCode;

                try
                {
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
