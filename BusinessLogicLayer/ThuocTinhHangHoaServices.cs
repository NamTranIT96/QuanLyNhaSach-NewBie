using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using BusinessEntities.EF;
namespace BusinessLogicLayer
{
    public class ThuocTinhHangHoaServices
    {
        private ThuocTinhHangHoaDAL thuocTinhHangHoaDAL;
        public ThuocTinhHangHoaServices()
        {
            thuocTinhHangHoaDAL = new ThuocTinhHangHoaDAL();
        }

        public string getThuocTinhHangHoa(int maThuocTinh)
        {
            string output = "";
            ThuocTinh temp = thuocTinhHangHoaDAL.getThuocTinhByMaThuocTinh(maThuocTinh);
            if (temp != null)
            {
                if (temp.MauSac != null)
                {
                    output += "Màu sắc: " + temp.MauSac + "\n";
                }
                if (temp.KichThuoc != null)
                {
                    output += "Kích thước: " + temp.KichThuoc + "\n";
                }
                if (temp.Khac != null)
                {
                    output += "Thông tin khác : " + temp.Khac + "\n";
                }
            }
            return output;
        }
        public List<string> getThongTinTTByMaThuocTinh(int maTT)
        {
            List<string> output = new List<string>();
            ThuocTinh temp = thuocTinhHangHoaDAL.getThuocTinhByMaThuocTinh(maTT);
            if (temp != null)
            {
                if (temp.MauSac != null)
                {
                    output.Add(temp.MauSac);
                }
                else
                {
                    output.Add("");
                }
                if (temp.KichThuoc != null)
                {
                    output.Add(temp.KichThuoc);
                }
                else
                {
                    output.Add("");
                }

                if (temp.Khac != null)
                {
                    output.Add(temp.Khac);
                }
                else
                {
                    output.Add("");
                }

                return output;
            }
            else
            {
                return null;
            }
        }

    }
}
