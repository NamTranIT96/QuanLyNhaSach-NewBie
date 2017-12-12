using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.EF;
namespace DataAccessLayer
{
    public class HoaDonTraHangDAL:BaseDAL
    {
        /// <summary>
        /// Thêm mới một hóa đơn trả hàng
        /// </summary>
        /// <param name="hoaDonTraHang"></param>
        /// <returns></returns>
        public bool addNewHoaDonTraHang(HoaDonTraHang hoaDonTraHang)
        {
            try
            {
                data.HoaDonTraHangs.Add(hoaDonTraHang);
                data.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public string getTheNewMaHoaDonTraHang()
        {
            if (data.HoaDonTraHangs.Count() == 0)
            {
                return "TH00000001";
            }
            else
            {
                var temp = data.HoaDonTraHangs.OrderByDescending(p => p.MaHoaDon_TraHang).
                    Select(r => r.MaHoaDon_TraHang).First().ToString();
                string getNumber = temp.Substring(2);
                int newNumber = Int32.Parse(getNumber) + 1;
                string stringNewNumber = newNumber.ToString();
                int lenght = stringNewNumber.Length;
                string output = "";

                switch (lenght)
                {
                    case 1:
                        {
                            output = "TH0000000" + stringNewNumber;
                            break;
                        }
                    case 2:
                        {
                            output = "TH000000" + stringNewNumber;
                            break;
                        }
                    case 3:
                        {
                            output = "TH00000" + stringNewNumber;
                            break;
                        }
                    case 4:
                        {
                            output = "TH0000" + stringNewNumber;
                            break;
                        }
                    case 5:
                        {
                            output = "TH000" + stringNewNumber;
                            break;
                        }
                    case 6:
                        {
                            output = "TH00" + stringNewNumber;
                            break;
                        }
                    case 7:
                        {
                            output = "TH0" + stringNewNumber;
                            break;
                        }
                    case 8:
                        {
                            output = "TH" + stringNewNumber;
                            break;
                        }
                }
                return output;
            }
        }

        public List<HoaDonTraHang> getAllHoaDonTraHang()
        {
            return data.HoaDonTraHangs.ToList();
        }
    }
}
