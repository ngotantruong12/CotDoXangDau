using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;
using DataAccessLayers;


namespace BusinessLogicLayers
{
    public class DoLuong_BUS
    {
        public static bool Them_DOLUONG(DoLuong dl)
        {
            return DoLuong_DAO.Them_DoLuong(dl);
        }
        public static bool EDIT_DOLUONG(DoLuong dl , string ma_dl)
        {
            return DoLuong_DAO.Edit_DoLuong(dl, ma_dl);
        }
        public static DoLuong Show_DOluong(string ma_dl)
        {
            return DoLuong_DAO.Show_DoLuong(ma_dl);
        }
    }
}
