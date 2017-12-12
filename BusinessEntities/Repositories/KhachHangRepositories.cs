using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Repositories
{
    public class KhachHangRepositories
    {
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string DienThoai { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string KhuVuc { get; set; }
        public double? TichDiem { get; set; }
    }
}
