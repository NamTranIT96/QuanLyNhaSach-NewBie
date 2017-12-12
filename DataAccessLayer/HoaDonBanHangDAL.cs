using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;
namespace DataAccessLayer
{
    public class HoaDonBanHangDAL : BaseDAL
    {
        /// <summary>
        /// Tạo ra mã hóa đơn tiếp theo và trả về mã hóa đơn đó
        /// </summary>
        /// <returns></returns>
        public string getTheNewMaHoaDonBanHang()
        {
            if (data.HoaDonBanHangs.Count() == 0)
            {
                return "HD00000001";
            }
            else
            {
                var temp = data.HoaDonBanHangs.OrderByDescending(p => p.MaHoaDon_BanHang).
                    Select(r => r.MaHoaDon_BanHang).First().ToString();
                string getNumber = temp.Substring(2);
                int newNumber = Int32.Parse(getNumber) + 1;
                string stringNewNumber = newNumber.ToString();
                int lenght = stringNewNumber.Length;
                string output = "";

                switch (lenght)
                {
                    case 1:
                        {
                            output = "HD0000000" + stringNewNumber;
                            break;
                        }
                    case 2:
                        {
                            output = "HD000000" + stringNewNumber;
                            break;
                        }
                    case 3:
                        {
                            output = "HD00000" + stringNewNumber;
                            break;
                        }
                    case 4:
                        {
                            output = "HD0000" + stringNewNumber;
                            break;
                        }
                    case 5:
                        {
                            output = "HD000" + stringNewNumber;
                            break;
                        }
                    case 6:
                        {
                            output = "HD00" + stringNewNumber;
                            break;
                        }
                    case 7:
                        {
                            output = "HD0" + stringNewNumber;
                            break;
                        }
                    case 8:
                        {
                            output = "HD" + stringNewNumber;
                            break;
                        }
                }
                return output;
            }
        }
        public string getCurrentMaHoaDonBanHang()
        {
            if (data.HoaDonBanHangs.Count() == 0)
            {
                return null;
            }
            else
            {
                var temp = data.HoaDonBanHangs.OrderByDescending(p => p.MaHoaDon_BanHang).
                    Select(r => r.MaHoaDon_BanHang).First().ToString();
                return temp;
            }
        }
        /// <summary>
        /// Thêm mới một hóa đơn bán hàng
        /// </summary>
        /// <param name="hoaDonBanHang_new"></param>
        /// <returns></returns>
        public bool addNewHoaDonBanHang(HoaDonBanHang hoaDonBanHang_new)
        {
            try
            {
                hoaDonBanHang_new.Status = true;
                data.HoaDonBanHangs.Add(hoaDonBanHang_new);
                data.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy tất cả hóa đơn bán hàng
        /// </summary>
        /// <returns></returns>
        public List<HoaDonBanHang> getAllHoaDonBanHAng()
        {
            return data.HoaDonBanHangs.Where(x => x.Status == true).ToList();
        }

        /// <summary>
        /// Get hóa đơn bán hàng từ mã hóa đơn
        /// </summary>
        /// <param name="maHoaDon"></param>
        /// <returns></returns>
        public HoaDonBanHang getHoaDonBanHangByMaHoaDon(string maHoaDon)
        {
            return data.HoaDonBanHangs.Where(x => x.MaHoaDon_BanHang == maHoaDon && x.Status == true).FirstOrDefault();
        }

        /// <summary>
        /// Tìm kiếm hóa đơn theo mã hóa đơn hoặc theo tên khách hàng hoặc cả hai
        /// </summary>
        /// <param name="maHoaDon"></param>
        /// <param name="tenKhachHang"></param>
        /// <returns></returns>
        public List<HoaDonBanHang> searchHoaDonBanHangTheoMaHoaDonHoacTenKhachHang(string maHoaDon, string tenKhachHang)
        {
            // các trường hợp xảy ra 
            if (maHoaDon != null)
            {
                // Truong hợp cả 2 đều khác null
                if (tenKhachHang != null)
                {
                    string maKhachHang = data.HoaDonBanHangs.Where(x => x.MaHoaDon_BanHang == maHoaDon && x.Status == true)
                        .FirstOrDefault().MaKhachHang;
                    if (maKhachHang != null)
                    {
                        string tenKhachHangTuMaKhachHang = data.KhachHangs.Where(x => x.MaKhachHang == maKhachHang).FirstOrDefault().TenKhachHang;
                        if (tenKhachHang == tenKhachHangTuMaKhachHang)
                        {
                            return data.HoaDonBanHangs.Where(x => x.MaHoaDon_BanHang == maHoaDon && x.Status == true).ToList();
                        }
                        else
                        {
                            return null;
                        }
                    }
                    else
                        return null;
                }
                else
                {
                    // trường hợp mã hóa đơn có giá trị nhưng tên khách hàng = null;
                    return data.HoaDonBanHangs.Where(x => x.MaHoaDon_BanHang == maHoaDon && x.Status == true).ToList();
                }

            }
            else
            {
                // trường hợp mã hóa đơn = null và tên khách hàng có giá trị
                if (tenKhachHang != null)
                {
                    List<KhachHang> listKhachHangTheoTen = data.KhachHangs.Where(x => x.TenKhachHang == tenKhachHang).ToList();
                    List<HoaDonBanHang> listHoaDonBanHang = new List<HoaDonBanHang>();

                    foreach (KhachHang x in listKhachHangTheoTen)
                    {
                        List<HoaDonBanHang> temp = data.HoaDonBanHangs.Where(a => a.MaKhachHang == x.MaKhachHang && a.Status == true).ToList();
                        foreach (HoaDonBanHang hoadon in temp)
                        {
                            listHoaDonBanHang.Add(hoadon);
                        }
                    }
                    return listHoaDonBanHang;
                }
                else
                {
                    return null;
                }
            }

        }

        public bool checkHoaDonCoTonTaiTheoMaHoaDon(string maHoaDon)
        {
            HoaDonBanHang temp = data.HoaDonBanHangs.Where(x => x.MaHoaDon_BanHang == maHoaDon && x.Status == true).FirstOrDefault();
            if (temp != null)
                return true;
            else
                return false;
        }

        public bool setStatusFasleByMaHoaDon(string maHD)
        {
            HoaDonBanHang temp = data.HoaDonBanHangs.Where(x => x.MaHoaDon_BanHang == maHD).FirstOrDefault();
            if (temp != null)
            {
                temp.Status = false;
                data.SaveChanges();
                return true;
            }
            else return false;
        }
    }
}
