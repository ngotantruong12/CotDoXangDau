using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
using DataTransferObject;
using System.Data;

namespace BusinessLogicLayers
{
   public class ThongTinCDXD_BUS
    {
        public static bool Add_ThongTinCDXD(thongtin_cdxd tt_cdxdbus)
        {
            return ThongTinCDXD_DAO.Them_ThongTinCDXD(tt_cdxdbus);
        }
        public static DataTable load_cbb()
        {
            return ThongTinCDXD_DAO.LoadCBB();
        }

        public static bool Edit_ThongTinCDXD(thongtin_cdxd Ett_cdxd, string Eid_cdxd)
        {
            return ThongTinCDXD_DAO.SuaThongTin_CDXD(Ett_cdxd, Eid_cdxd);
        }

        public static thongtin_cdxd Xem_ThongTinCDXD(string Xem_idcdxd)
        {
            return ThongTinCDXD_DAO.XemThongTin_CDXD(Xem_idcdxd);
        }
    }
}
