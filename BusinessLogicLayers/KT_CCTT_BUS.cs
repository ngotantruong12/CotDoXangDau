using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessLayers;

namespace BusinessLogicLayers
{
     public   class KT_CCTT_BUS
    {
        public static bool Them_COCAU(KT_CCTT cctt)
        {
            return KT_COCAU_DAO.Them_CCTT(cctt);
        }
        public static bool Edit_CCTT(KT_CCTT cctt, string ma_cctt)
        {
            return KT_COCAU_DAO.Edit_CCTT(cctt, ma_cctt);
        }
        public static KT_CCTT Show_CCTT(string ma_cctt)
        {
            return KT_COCAU_DAO.Show_CCTT(ma_cctt);
        }
    }
}
