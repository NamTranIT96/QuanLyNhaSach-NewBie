using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Repositories
{
    public class HoaDonTraHangRepositories
    {
        public string MaHoaDon_TraHang { get; set; }

        public string MaHoaDon_BanHang { get; set; }

        public string TenKhachHang { get; set; }

        public string TenNguoiDung { get; set; }        

        public DateTime? NgayGio { get; set; }

        public double? ThanhTien { get; set; }

        public double? PhiTraHang { get; set; }

        public double? TienTraLaiKhach { get; set; }

    }
}
