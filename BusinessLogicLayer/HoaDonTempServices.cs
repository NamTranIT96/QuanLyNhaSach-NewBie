using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Repositories;
using DataAccessLayer;
using System.Data;

namespace BusinessLogicLayer
{

    public class HoaDonTempServices
    {
        private HoaDonTempDAL hoaDonTempDAL;
        public HoaDonTempServices()
        {
            hoaDonTempDAL = new HoaDonTempDAL();
        }
        public bool addHoaDonTemp(string tenHoaDon)
        {
            HoaDonTempRepositories temp = new HoaDonTempRepositories();
            temp.tenHoaDon = tenHoaDon;
            try
            {
                if (hoaDonTempDAL.addHoaDonToListHoaDonTemp(temp)) return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }
        // Thêm hàng hoá vào hoá đơn đã có
        public bool addHangHoaToHoaDonByTenHoaDon(string tenHoaDon, string maHH, string tenHH,
            string donViTinh, int soLuong, double giaTien, double tongCong)
        {
            HoaDonTempRepositories temp = hoaDonTempDAL.getHoaDonByTenHoaDon(tenHoaDon);
            HangHoaTempRepositories hanghoatemp = new HangHoaTempRepositories();
            hanghoatemp.maHangHoa = maHH;
            hanghoatemp.tenHangHoa = tenHH;
            hanghoatemp.donViTinh = donViTinh;
            hanghoatemp.soLuong = soLuong;
            hanghoatemp.giaTien = giaTien;
            hanghoatemp.tongCong = tongCong;

            if (temp != null)
            {
                if (temp.addHangHoaToHoaDonTemp(hanghoatemp)) return true;
                else
                    return false;
            }
            else
                return false;
        }
        // Chỉnh sửa thông tin hàng hoá : số lượng và tổng tiền

        public bool editHangHoaInHoaDon(string tenHoaDon, string maHH, int soluong)
        {
            HoaDonTempRepositories temp = hoaDonTempDAL.getHoaDonByTenHoaDon(tenHoaDon);
            if (temp != null)
            {
                foreach (HangHoaTempRepositories x in temp.getAllListHangHoaRespo())
                {
                    if (x.maHangHoa == maHH)
                    {
                        int temp_soluong = x.soLuong;
                        x.soLuong = temp_soluong + soluong;
                        x.tongCong = x.soLuong * x.giaTien;
                        return true;
                    }

                }
                return false;
            }
            else
                return false;
        }
        public DataTable getAllHangHoaInHoaDonByTenHoaDon(string tenHD)
        {
            return hoaDonTempDAL.getAllHangHoaInHoaDonByTenHoaDon(tenHD);
        }

        /// <summary>
        /// xóa hóa đơn temp trong list hóa đơn temp bằng tên hóa đơn
        /// </summary>
        /// <param name="tenHoaDon"></param>
        /// <returns></returns>
        public bool deleteHoaDonInListHoaDonTempByTenHoaDon(string tenHoaDon)
        {
            if (hoaDonTempDAL.deleteHoaDonTempInListHoaDonTempByTenHoaDon(tenHoaDon))
            {
                return true;
            }
            else return false;
        }

        // hàm get Tổng tiền của 1 hóa đơn bởi tên hóa đơn
        public double getTongTienByTenHoaDon(string tenHoaDon)
        {
            return hoaDonTempDAL.getTongTienHoaDonByTenHoaDon(tenHoaDon);
        }

        // Thêm mã khách hàng vào hóa đơn theo tên hóa đơn
        public bool setMaKHByTenHoaDon(string tenHoaDon, string maKH)
        {
            return hoaDonTempDAL.setMaKHByTenHoaDon(tenHoaDon, maKH);
        }
        // thêm số tiền khách hàng trả trong hóa đơn temp theo tên hóa đơn
        public bool setTienKhachHangTra(string tenHoaDon, double tienTra)
        {
            return hoaDonTempDAL.setTienKhachHangTraByTenHoaDon(tenHoaDon, tienTra);
        }

        public List<string> getMaKHAndTienTraByTenHoaDon(string tenHoaDon)
        {
            return hoaDonTempDAL.getMaKHAndTienTraByTenHoaDon(tenHoaDon);
        }

        // lấy hóa đơn temp từ tên hóa đơn
        public HoaDonTempRepositories getHoaDonTempByTenHoaDon(string tenHoaDon)
        {
            return hoaDonTempDAL.getHoaDonByTenHoaDon(tenHoaDon);
        }

        public bool deleteHangHoaInHoaDonTemByTenHoaDonAndMaHangHoa(string tenHoaDon, string maHangHoa)
        {
            if (hoaDonTempDAL.deleteHangHoaInHoaDonTemByTenHoaDonAndMaHangHoa(tenHoaDon, maHangHoa)) return true;
            else return false;
        }

        public List<HangHoaTempRepositories> getAllHangHoaTempByTenHoaDon(string tenHoaDon)
        {
            return hoaDonTempDAL.getAllHangHoaTempByTenHoaDon(tenHoaDon);
        }
    }
}
