using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
using DataTransferObject;

namespace BusinessLogicLayers
{
    public class KTNgoai_BUS
    {

         public  static bool Them_KTNgoai(KTNgoai_DTO ktn)
        {
            return KTNgoai_DAO.Them_KTNgoai(ktn);
        }
         public static bool Edit_KTNgoai(KTNgoai_DTO ktn, String ma_ktn)
         {
             return KTNgoai_DAO.Edit_KTNgoai(ktn,ma_ktn);
         }
         public static KTNgoai_DTO Show_KTNgoai(string ma_dl)
         {
             return KTNgoai_DAO.Show_KTNgoai( ma_dl);
         }
    }
}
