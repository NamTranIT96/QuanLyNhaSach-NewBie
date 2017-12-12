using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Repositories
{
    public class HangHoaBangGiaRepositories
    {
        public string MaHangHoa { get; set; }

        public string TenHang { get; set; }

        public double? GiaVon { get; set; }

        public double? GiaBan { get; set; } // cũng là giá nhập cuối
    }
}
