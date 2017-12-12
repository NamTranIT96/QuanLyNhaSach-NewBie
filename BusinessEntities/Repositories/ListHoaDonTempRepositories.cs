using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Repositories
{
    public class ListHoaDonTempRepositories
    {
        private List<HoaDonTempRepositories> listHoaDonTemp;
        public ListHoaDonTempRepositories()
        {
            listHoaDonTemp = new List<HoaDonTempRepositories>();
        }
        /// <summary>
        /// Thêm một hoá đơn temp vào list hoá đơn temp, tức là sẽ có một danh sách các hóa đơn temp
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public bool addHoaDonToListHoaDonTemp(HoaDonTempRepositories temp)
        {
            try
            {
                foreach (HoaDonTempRepositories x in listHoaDonTemp)
                {
                    if (x.tenHoaDon == temp.tenHoaDon) return false;
                }
                listHoaDonTemp.Add(temp);
                return true;
            }
            catch (Exception)
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
            foreach (HoaDonTempRepositories x in listHoaDonTemp)
            {
                if (x.tenHoaDon == tenHoaDon)
                    return x;
            }
            return null;
        }

        /// <summary>
        /// Lấy tất cả hàng hóa trong hóa đơn từ tên hóa đơn
        /// </summary>
        /// <param name="tenHoaDon"></param>
        /// <returns></returns>
        public DataTable getAllHangHoaInHoaDonByTenHoaDon(string tenHoaDon)
        {
            foreach (HoaDonTempRepositories x in listHoaDonTemp)
            {
                if (x.tenHoaDon == tenHoaDon)
                {
                    return x.getAllHangHoa();
                }
            }
            return null;
        }

        /// <summary>
        /// Xóa hóa đơn temp từ tên hóa đơn
        /// </summary>
        /// <param name="tenHoaDon"></param>
        /// <returns></returns>
        public bool deleteHoaDonByTenHoaDon(string tenHoaDon)
        {

            for(int i=0;i<listHoaDonTemp.Count;i++)
            {
                if(listHoaDonTemp[i].tenHoaDon == tenHoaDon)
                {
                    try
                    {
                        listHoaDonTemp[i] = null;
                        listHoaDonTemp.Remove(listHoaDonTemp[i]);
                        return true;
                    }
                    catch(Exception)
                    {
                        throw;
                    }
                }
            }

            //foreach (HoaDonTempRepositories x in listHoaDonTemp)
            //{
            //    if (x.tenHoaDon == tenHoaDon)
            //    {
            //        try
            //        {
            //            listHoaDonTemp.Remove(x);
            //            return true;
            //        }
            //        catch (Exception)
            //        {
            //            throw;
            //        }
            //    }
            //}
            return false;
        }

        /// <summary>
        ///  Hàm get tổng tiền của hóa đơn cần tiền
        /// </summary>
        /// <param name="tenHoaDon"></param>
        /// <returns></returns>
        public double getTongTienHoaDonByTenHoaDon(string tenHoaDon)
        {
            foreach (HoaDonTempRepositories x in listHoaDonTemp)
            {
                if (x.tenHoaDon == tenHoaDon)
                {
                    return x.getTongTienAllHangHoa();
                }
            }
            return -1;
        }


        /// <summary>
        /// Đặt mã khách hàng vào hóa đơn temp,
        /// </summary>
        /// <param name="tenHoaDon"></param>
        /// <param name="maKH"></param>
        /// <returns></returns>
        public bool setMaKHByTenHoaDon(string tenHoaDon, string maKH)
        {
            foreach (HoaDonTempRepositories x in listHoaDonTemp)
            {
                if (x.tenHoaDon == tenHoaDon)
                {
                    try
                    {
                        x.setMaKH(maKH);
                        return true;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return false;
        }
        /// <summary>
        /// Đặt mã khách hàng vào hóa đơn temp,
        /// </summary>
        /// <param name="tenHoaDon"></param>
        /// <param name="tienTra"></param>
        /// <returns></returns>
        public bool setTienKhachHangTraByTenHoaDon(string tenHoaDon, double tienTra)
        {
            foreach (HoaDonTempRepositories x in listHoaDonTemp)
            {
                if (x.tenHoaDon == tenHoaDon)
                {
                    try
                    {
                        x.setTienKhachHangTra(tienTra);
                        return true;
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return false;
        }

        public List<string> getMaKHAndTienTraByTenHoaDon(string tenHoaDon)
        {
            foreach (HoaDonTempRepositories x in listHoaDonTemp)
            {
                if (x.tenHoaDon == tenHoaDon)
                {
                    try
                    {
                        return x.getMaKHAndTienTra();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return null;
        }

        public bool deleteHangHoaInHoaDonTemByTenHoaDonAndMaHangHoa(string tenHoaDon, string maHangHoa)
        {
            foreach(HoaDonTempRepositories hoaDonTemp in listHoaDonTemp)
            {
                if(hoaDonTemp.tenHoaDon == tenHoaDon)
                {
                    // thực hiện xóa hàng hóa ra khỏi hóa đơn này
                    if (hoaDonTemp.deleteHangHoaByMaHangHoa(maHangHoa)) return true;
                    else return false;
                }             
            }
            return false;
        }
        public List<HangHoaTempRepositories> getAllHangHoaTempByTenHoaDon(string tenHoaDon)
        {
            foreach (HoaDonTempRepositories x in listHoaDonTemp)
            {
                if (x.tenHoaDon == tenHoaDon)
                {
                    try
                    {
                        return x.getListhoaDonTemp();
                    }
                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
            return null;
        }

    }
}
