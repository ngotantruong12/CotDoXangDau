using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;

namespace BusinessLogicLayers
{
     public class Tem_BUS
    {
         public static bool TIM_TEM(int tem)
         {
             return TEM_DAO.TimTEM(tem);
         }
         public static bool THEM_TEM(int tem)
         {
             return TEM_DAO.THEM_TEM(tem);
         }
    }
}
