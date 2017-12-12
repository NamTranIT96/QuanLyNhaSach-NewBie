using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Repositories
{
    public class HoaDonTempRepositories
    {
        private List<HangHoaTempRepositories> hoaDonTemp;

        // Tên của hoá đơn, để sau này so sánh
        public string tenHoaDon { get; set; }

        public string maKH { get; set; } = "Khách lẻ";

        public double tienKhachHangTra { get; set; } = 0;

        public HoaDonTempRepositories()
        {
            hoaDonTemp = new List<HangHoaTempRepositories>();
        }

        public List<HangHoaTempRepositories> getListhoaDonTemp()
        {
            return hoaDonTemp;
        }

        /// <summary>
        /// Thêm một hàng hoá temp vào list hàng hoá ( tức hoá đơn temp)
        /// </summary>
        /// <param name="temp"></param>
        /// <returns></returns>
        public bool addHangHoaToHoaDonTemp(HangHoaTempRepositories temp)
        {
            try
            {
                hoaDonTemp.Add(temp);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public List<HangHoaTempRepositories> getAllListHangHoaRespo()
        {
            return hoaDonTemp;
        }

        public DataTable getAllHangHoa()
        {
            DataTable output = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(HangHoaTempRepositories));
            foreach (PropertyDescriptor prop in properties)
            {
                output.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (HangHoaTempRepositories hanghoa in hoaDonTemp)
            {
                DataRow row = output.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(hanghoa) ?? DBNull.Value;
                }
                output.Rows.Add(row);
            }
            return output;
        }

        // hàm get tổng tiền của tất cả các hàng hóa
        public double getTongTienAllHangHoa()
        {
            double ouput = 0.0f;
            foreach(HangHoaTempRepositories x in hoaDonTemp)
            {
                ouput += x.tongCong;
            }
            return ouput;
        }

        public void setMaKH(string maKH)
        {
            this.maKH = maKH;
        }

        public void setTienKhachHangTra(double tienTra)
        {
            this.tienKhachHangTra = tienTra;
        }

        public List<string> getMaKHAndTienTra()
        {
            List<string> output = new List<string>();
            output.Add(maKH);
            output.Add(tienKhachHangTra.ToString());
            return output;
        }
        /// <summary>
        /// Xóa một loại hàng hóa trong hóa đơn temp
        /// </summary>
        /// <param name="maHangHoa"></param>
        /// <returns></returns>
        public bool deleteHangHoaByMaHangHoa(string maHangHoa)
        {
            foreach(HangHoaTempRepositories hanghoa in hoaDonTemp)
            {
                if(hanghoa.maHangHoa == maHangHoa)
                {
                    hoaDonTemp.Remove(hanghoa);
                    return true;
                }
            }
            return false;
        }
    }
}
