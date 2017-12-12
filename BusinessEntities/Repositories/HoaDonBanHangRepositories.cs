using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Repositories
{
    public class HoaDonBanHangRepositories
    {
        public string MaHoaDon_BanHang { get; set; }

        public string TenKhachHang { get; set; }

        public string TenNguoiDung { get; set; }

        public DateTime? NgayGio { get; set; }

        public double? TongTien { get; set; }

        public double? ChietKhau { get; set; }

        public double? TongCong { get; set; }
    }
}
