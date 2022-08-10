using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
using DataTransferObject;

namespace BusinessLogicLayers
{
    public class KTKyThuat_BUS
    {
        public static bool Them_KTKyThuat(KTKyThuat_DTO ktk)
        {
            return KTKyThuat_DAO.Them_KTKyThuat(ktk);
        }
        public static bool Edit_KTKyThuat(KTKyThuat_DTO ktk, String ma_ktk)
        {
            return KTKyThuat_DAO.Edit_KTKyThuat(ktk, ma_ktk);
        }
        public static KTKyThuat_DTO Show_KTKyThuat(string ma_dl)
        {
            return KTKyThuat_DAO.Show_KTKyThuat(ma_dl);
        }
    }
}
