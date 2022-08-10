using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
using DataTransferObject;

namespace BusinessLogicLayers
{
    public class OngMem_BUS
    {
        public static bool Them_OM(OngMem_In_DTO om)
        {
            return OngMem_DAO.Them_ongmem(om);
        }
        public static bool Edit_OM(OngMem_In_DTO om, string ma_om)
        {
            return OngMem_DAO.Edit_ongmem(om , ma_om);
        }
        public static OngMem_In_DTO show_OM(string ma_om)
        {
            return OngMem_DAO.Show_ongmem(ma_om);
        }
    }
}
