using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Repositories;
using System.Data;

namespace DataAccessLayer
{
    public class HoaDonTempDAL
    {
        private ListHoaDonTempRepositories listHoaDonTempRepo;
        public HoaDonTempDAL()
        {
            listHoaDonTempRepo = new ListHoaDonTempRepositories();
        }
        /// <summary>
        /// thêm một hóa đơn temp vào list hóa đơn temp
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public bool addHoaDonToListHoaDonTemp(HoaDonTempRepositories temp)
        {
            try
            {
                if (listHoaDonTempRepo.addHoaDonToListHoaDonTemp(temp))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// Lấy hóa đơn temp từ tên hóa đơn
        /// </summary>
        /// <param name="tenHoaDon"></param>
        /// <returns></returns>
        public HoaDonTempRepositories getHoaDonByTenHoaDon(string tenHoaDon)
        {
            return listHoaDonTempRepo.getHoaDonByTenHoaDon(tenHoaDon);
        }
        // Lấy tất cả các hàng hóa trong hóa đơn từ tên hóa đơn
        public DataTable getAllHangHoaInHoaDonByTenHoaDon(string tenHD)
        {
            return listHoaDonTempRepo.getAllHangHoaInHoaDonByTenHoaDon(tenHD);
        }
        // Xóa một hóa đơn emp trong list hóa đơn theo tên hóa đơn temp
        public bool deleteHoaDonTempInListHoaDonTempByTenHoaDon(string tenHoaDon)
        {
            if (listHoaDonTempRepo.deleteHoaDonByTenHoaDon(tenHoaDon))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        // get tổng tiền của 1 hóa đơn từ tên hóa đơn
        public double getTongTienHoaDonByTenHoaDon(string tenHoaDon)
        {
            return listHoaDonTempRepo.getTongTienHoaDonByTenHoaDon(tenHoaDon);
        }

        // Thêm mã khách hàng vào hóa đơn theo tên hóa đơn
        public bool setMaKHByTenHoaDon(string tenHoaDon,string maKH)
        {
            return listHoaDonTempRepo.setMaKHByTenHoaDon(tenHoaDon, maKH);
        }
        // thêm số tiền khách hàng trả trong hóa đơn temp theo tên hóa đơn
        public bool setTienKhachHangTraByTenHoaDon(string tenHoaDon,double tienTra)
        {
            return listHoaDonTempRepo.setTienKhachHangTraByTenHoaDon(tenHoaDon, tienTra);
        }

        public List<string> getMaKHAndTienTraByTenHoaDon(string tenHoaDon)
        {
            return listHoaDonTempRepo.getMaKHAndTienTraByTenHoaDon(tenHoaDon);
        }
        public bool deleteHangHoaInHoaDonTemByTenHoaDonAndMaHangHoa(string tenHoaDon,string maHangHoa)
        {
            if (listHoaDonTempRepo.deleteHangHoaInHoaDonTemByTenHoaDonAndMaHangHoa(tenHoaDon, maHangHoa)) return true;
            else return false;
        }
        public List<HangHoaTempRepositories> getAllHangHoaTempByTenHoaDon(string tenHoaDon)
        {
            return listHoaDonTempRepo.getAllHangHoaTempByTenHoaDon(tenHoaDon);
        }
    }
}
