using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
using DataTransferObject;

namespace BusinessLogicLayers
{
    public class LuuLuongCPTT_BUS
    {
        public static bool Add_LuuLuongCPTT(LuuLuongCPTT LL_CPPTT)
        {
            return LuuLuongCPTT_DAO.Them_LuuLuongCPTT(LL_CPPTT);
        }

        public static bool Fix_LuuLuongCPTT(LuuLuongCPTT FLL_CPTT, string ID_CPTT)
        {
            return LuuLuongCPTT_DAO.Sua_LuuLuongCPTT(FLL_CPTT, ID_CPTT);
        }

        public static LuuLuongCPTT Xem_LuuLuongCPTT(string IDCPTT)
        {
            return LuuLuongCPTT_DAO.XemLuuLuongCPTT(IDCPTT);
        }
    }
}
