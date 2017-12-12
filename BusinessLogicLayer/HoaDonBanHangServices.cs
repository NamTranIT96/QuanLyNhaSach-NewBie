using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities.Repositories;
using BusinessEntities.EF;
using System.Data;
using System.ComponentModel;

namespace BusinessLogicLayer
{
    public class HoaDonBanHangServices
    {
        HoaDonBanHangDAL hoaDonBanHangDAL;
        KhachHangDAL khachHangDAL;
        NguoiDungDAL nguoiDungDAL;
        SanPhamHoaDonDAL sanPhamHoaDonDAL;
        HoaDonTempDAL hoaDonTempDAL;

        public HoaDonBanHangServices()
        {
            hoaDonBanHangDAL = new HoaDonBanHangDAL();
            khachHangDAL = new KhachHangDAL();
            nguoiDungDAL = new NguoiDungDAL();
            sanPhamHoaDonDAL = new SanPhamHoaDonDAL();
            hoaDonTempDAL = new HoaDonTempDAL();
        }
        /// <summary>
        /// Thêm mới hóa đơn bán hàng và thêm các sản phẩm của từng hóa đơn vào sản phảm hóa đơn
        /// </summary>
        /// <param name="hoaDonTemp"></param>
        /// <param name="maND"></param>
        /// <param name="ngayGio"></param>
        /// <returns></returns>
        public bool addNewHoaDonBanHangAndSanPhamHoaDon(HoaDonTempRepositories hoaDonTemp, string maND, DateTime ngayGio)
        {
            if (hoaDonTemp != null)
            {
                HoaDonBanHang hoaDonBanHang_Add = new HoaDonBanHang();
                string maHoaDon = hoaDonBanHangDAL.getTheNewMaHoaDonBanHang();
                string maKH = hoaDonTemp.maKH;
                string maNguoiBanHang = maND;
                double tongTien = hoaDonTemp.getTongTienAllHangHoa();

                if (maKH == "Khách lẻ")
                {
                    // nếu là khách lẻ thì chiết khấu luôn =0 và mã khách hàng = null
                    // và tổng tiền = tổng cộng
                    hoaDonBanHang_Add.MaHoaDon_BanHang = maHoaDon;
                    hoaDonBanHang_Add.MaKhachHang = null;
                    hoaDonBanHang_Add.MaNguoiDung = maNguoiBanHang;
                    hoaDonBanHang_Add.NgayGio = ngayGio;
                    hoaDonBanHang_Add.TongTien = tongTien;
                    hoaDonBanHang_Add.ChietKhau = 0;
                    hoaDonBanHang_Add.TongCong = tongTien;

                    if (hoaDonBanHangDAL.addNewHoaDonBanHang(hoaDonBanHang_Add))
                    {
                        // nếu thêm hoa đơn thành công thì thêm các hàng hóa vào sản phẩm hóa đơn
                        foreach (HangHoaTempRepositories x in hoaDonTemp.getListhoaDonTemp())
                        {
                            SanPhamHoaDon sanPhamHoaDon_Add = new SanPhamHoaDon();
                            sanPhamHoaDon_Add.MaHoaDon = maHoaDon;
                            sanPhamHoaDon_Add.MaHangHoa = x.maHangHoa;
                            sanPhamHoaDon_Add.TenHang = x.tenHangHoa;
                            sanPhamHoaDon_Add.SoLuong = x.soLuong;
                            sanPhamHoaDon_Add.TongTien = x.tongCong;
                            if (!sanPhamHoaDonDAL.addNewSanPhamHoaDon(sanPhamHoaDon_Add))
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    else return false;

                }
                else
                {
                    //nếu là một khách hàng nào đó
                    hoaDonBanHang_Add.MaHoaDon_BanHang = maHoaDon;
                    hoaDonBanHang_Add.MaKhachHang = maKH;
                    hoaDonBanHang_Add.MaNguoiDung = maNguoiBanHang;
                    hoaDonBanHang_Add.NgayGio = ngayGio;
                    hoaDonBanHang_Add.TongTien = tongTien;
                    hoaDonBanHang_Add.ChietKhau = (khachHangDAL.getSoPhanTramTichDiem(maKH) / 100) * tongTien;
                    hoaDonBanHang_Add.TongCong = hoaDonBanHang_Add.TongTien - hoaDonBanHang_Add.ChietKhau;

                    if (hoaDonBanHangDAL.addNewHoaDonBanHang(hoaDonBanHang_Add))
                    {
                        // nếu thêm hóa đơn thành công thì thêm các hàng hóa vào sản phẩm hóa đơn
                        foreach (HangHoaTempRepositories x in hoaDonTemp.getListhoaDonTemp())
                        {
                            SanPhamHoaDon sanPhamHoaDon_Add = new SanPhamHoaDon();
                            sanPhamHoaDon_Add.MaHoaDon = maHoaDon;
                            sanPhamHoaDon_Add.MaHangHoa = x.maHangHoa;
                            sanPhamHoaDon_Add.TenHang = x.tenHangHoa;
                            sanPhamHoaDon_Add.SoLuong = x.soLuong;
                            sanPhamHoaDon_Add.TongTien = x.tongCong;
                            if (!sanPhamHoaDonDAL.addNewSanPhamHoaDon(sanPhamHoaDon_Add))
                            {
                                return false;
                            }
                        }
                        return true;
                    }
                    else
                        return false;
                }
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy tất cả hóa đơn bán hàng ra datatable
        /// </summary>
        /// <returns></returns>
        public DataTable getAllHoaDonBanHang()
        {
            DataTable output = new DataTable();
            List<HoaDonBanHang> listHDBH = hoaDonBanHangDAL.getAllHoaDonBanHAng();
            List<HoaDonBanHangRepositories> listHDBHRepo = new List<HoaDonBanHangRepositories>();
            foreach(HoaDonBanHang x in listHDBH)
            {
                HoaDonBanHangRepositories temp = new HoaDonBanHangRepositories();
                temp.MaHoaDon_BanHang = x.MaHoaDon_BanHang;
                if (x.MaKhachHang != null)
                    temp.TenKhachHang = khachHangDAL.getTenKhachHangByMaKH(x.MaKhachHang);
                else
                    temp.TenKhachHang = "Khách lẻ";
                temp.TenNguoiDung = nguoiDungDAL.getTenNguoiDungByMaNguoiDung(x.MaNguoiDung);
                temp.NgayGio = x.NgayGio;
                temp.TongTien = x.TongTien;
                temp.ChietKhau = x.ChietKhau;
                temp.TongCong = x.TongCong;
                listHDBHRepo.Add(temp);
            }

            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(HoaDonBanHangRepositories));
            foreach (PropertyDescriptor prop in properties)
            {
                output.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (HoaDonBanHangRepositories hoaDonBanHang in listHDBHRepo)
            {
                DataRow row = output.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(hoaDonBanHang) ?? DBNull.Value;
                }
                output.Rows.Add(row);
            }
            return output;
        }

        public HoaDonBanHang getHoaDonBanHangByMaHoaDon(string maHoaDon)
        {
            return hoaDonBanHangDAL.getHoaDonBanHangByMaHoaDon(maHoaDon);
        }
        /// <summary>
        /// Lay tat ca ma hoa don vao list string
        /// </summary>
        /// <returns></returns>
        public List<string> getAllMaHoaDon()
        {
            List<HoaDonBanHang> temp = hoaDonBanHangDAL.getAllHoaDonBanHAng();
            List<string> ouput = new List<string>();
            foreach(HoaDonBanHang x in temp)
            {
                ouput.Add(x.MaHoaDon_BanHang);
            }
            return ouput;
        }
        /// <summary>
        /// Tìm kiếm hóa đơn bán hàng theo mã hóa đơn hoặc theo tên khách hàng theo dạng datatable
        /// </summary>
        /// <param name="maHoaDon"></param>
        /// <param name="tenKhachHang"></param>
        /// <returns></returns>
        public DataTable searchHoaDonBanHangTheoMaHoaDonHoacTenKhachHang(string maHoaDon = null, string tenKhachHang = null)
        {
            List<HoaDonBanHang> listHoaDonBanHang = hoaDonBanHangDAL.searchHoaDonBanHangTheoMaHoaDonHoacTenKhachHang(maHoaDon, tenKhachHang);
            List<HoaDonBanHangRepositories> listHoaDonBanHangRepo = new List<HoaDonBanHangRepositories>();
            if (listHoaDonBanHang != null)
            {
                foreach (HoaDonBanHang x in listHoaDonBanHang)
                {
                    HoaDonBanHangRepositories temp = new HoaDonBanHangRepositories();
                    temp.MaHoaDon_BanHang = x.MaHoaDon_BanHang;
                    if (x.MaKhachHang != null)
                        temp.TenKhachHang = khachHangDAL.getTenKhachHangByMaKH(x.MaKhachHang);
                    else
                        temp.TenKhachHang = "Khách lẻ";
                    temp.TenNguoiDung = nguoiDungDAL.getTenNguoiDungByMaNguoiDung(x.MaNguoiDung);
                    temp.NgayGio = x.NgayGio;
                    temp.TongTien = x.TongTien;
                    temp.ChietKhau = x.ChietKhau;
                    temp.TongCong = x.TongCong;

                    listHoaDonBanHangRepo.Add(temp);
                }
            }
            else
            {

            }

            DataTable output = new DataTable();
            PropertyDescriptorCollection properties = TypeDescriptor.GetProperties(typeof(HoaDonBanHangRepositories));
            foreach (PropertyDescriptor prop in properties)
            {
                output.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }
            foreach (HoaDonBanHangRepositories hoaDon in listHoaDonBanHangRepo)
            {
                DataRow row = output.NewRow();
                foreach (PropertyDescriptor prop in properties)
                {
                    row[prop.Name] = prop.GetValue(hoaDon) ?? DBNull.Value;
                }
                output.Rows.Add(row);
            }
            return output;
        }

        public bool checkHoaDonCoTonTaiTheoMaHoaDon(string maHoaDon)
        {
            return hoaDonBanHangDAL.checkHoaDonCoTonTaiTheoMaHoaDon(maHoaDon);
        }

        public bool setStatusFasleByMaHoaDon(string maHD)
        {
            return hoaDonBanHangDAL.setStatusFasleByMaHoaDon(maHD);
        }
        public string getCurrentMaHoaDonBanHang()
        {
            return hoaDonBanHangDAL.getCurrentMaHoaDonBanHang();
        }
    }
}
