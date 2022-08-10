using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayers;
using DataTransferObject;
using System.Data;
using System.Data.SqlClient;


namespace DataAccessLayers
{
    public class DoLuong_DAO
    {
       static SqlConnection conn;
       public static bool Them_DoLuong(DoLuong dl)
       {
           string query = string.Format(@"INSERT INTO KT_DOLUONG VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}',N'{13}',N'{14}',N'{15}',N'{16}',N'{17}',N'{18}',N'{19}',N'{20}',N'{21}',N'{22}',N'{23}',N'{24}',N'{25}',N'{26}',N'{27}',N'{28}',N'{29}',N'{30}',N'{31}',N'{32}',N'{33}',N'{34}',N'{35}',N'{36}',N'{37}',N'{38}',N'{39}',N'{40}')",dl.Id_doluong, dl.Tg_capphat, dl.Sothetich, dl.Luuluong_qmax, dl.ketLuan_qmax, dl.vfd_max_t1, dl.vref_max_t1, dl.efd_max_t1, dl.vfd_max_t2, dl.vref_max_t2, dl.efd_max_t2, dl.delta_EFD_maxT, dl.eav_max_t, dl.Ketluan_qmax_t, dl.vfd_min_t1, dl.vref_min_t1, dl.efd_min_t1, dl.vfd_min_t2, dl.vref_min_t2, dl.efd_min_t2, dl.delta_EFD_minT, dl.eav_min_t, dl.Ketluan_qmin_t, dl.vfd_max_s1, dl.vref_max_s1, dl.efd_max_s1, dl.vfd_max_s2, dl.vref_max_s2, dl.efd_max_s2, dl.delta_EFD_maxS, dl.eav_max_s, dl.Ketluan_qmax_s, dl.vfd_min_s1, dl.vref_min_s1, dl.efd_min_s1, dl.vfd_min_s2, dl.vref_min_s2, dl.efd_min_s2, dl.delta_EFD_minS, dl.eav_min_s, dl.Ketluan_qmin_s);
           conn = Dataprovider.moketnoi();
           bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, conn);
           return kq;
       }

       public static bool Edit_DoLuong(DoLuong dl, string ma_dl )
       {
           string query = string.Format(@"UPDATE KT_DOLUONG SET TG_CapPhat= N'{0}',SoTheTich= N'{1}',LuuLuong_Qmax= N'{2}',KetLuan_Qmax = N'{3}', VFD_max_T1 = N'{4}', VREF_max_T1= N'{5}',EFD_max_T1= N'{6}',VFD_max_T2= N'{7}',VREF_max_T2 = N'{8}',EFD_max_T2=N'{9}',delta_EFD_maxT=N'{10}',EAV_max_T= N'{11}',KL_Qmax_T =N'{12}',VFD_min_T1= N'{13}', VREF_min_T1= N'{14}',EFD_min_T1 =N'{15}',VFD_min_T2 = N'{16}',VREF_min_T2 =N'{17}', EFD_min_T2= N'{18}',delta_EFD_minT = N'{19}',EAV_min_T= N'{20}',KL_Qmin_T= N'{21}',VFD_max_S1= N'{22}',VREF_max_S1=N'{23}',EFD_max_S1= N'{24}',VFD_max_S2= N'{25}',VREF_max_S2= N'{26}',EFD_max_S2= N'{27}',delta_EFD_maxS= N'{28}',EAV_max_S= N'{29}',KL_Qmax_S =N'{30}',VFD_min_S1=N'{31}',VREF_min_S1=N'{32}',EFD_min_S1=N'{33}',VFD_min_S2= N'{34}',VREF_min_S2 =N'{35}',EFD_min_S2 = N'{36}',delta_EFD_minS= N'{37}',EAV_min_S = N'{38}',KL_Qmin_S = N'{39}'WHERE id_DL = N'{40}'",dl.Tg_capphat, dl.Sothetich, dl.Luuluong_qmax, dl.ketLuan_qmax, dl.vfd_max_t1, dl.vref_max_t1, dl.efd_max_t1, dl.vfd_max_t2, dl.vref_max_t2, dl.efd_max_t2, dl.delta_EFD_maxT, dl.eav_max_t, dl.Ketluan_qmax_t, dl.vfd_min_t1, dl.vref_min_t1, dl.efd_min_t1, dl.vfd_min_t2, dl.vref_min_t2, dl.efd_min_t2, dl.delta_EFD_minT, dl.eav_min_t, dl.Ketluan_qmin_t, dl.vfd_max_s1, dl.vref_max_s1, dl.efd_max_s1, dl.vfd_max_s2, dl.vref_max_s2, dl.efd_max_s2, dl.delta_EFD_maxS, dl.eav_max_s, dl.Ketluan_qmax_s, dl.vfd_min_s1, dl.vref_min_s1, dl.efd_min_s1, dl.vfd_min_s2, dl.vref_min_s2, dl.efd_min_s2, dl.delta_EFD_minS, dl.eav_min_s, dl.Ketluan_qmin_s, ma_dl);
           conn = Dataprovider.moketnoi();
           bool kq = Dataprovider.TruyVanKhongLayDuLieu(query, conn);
           return kq;
       }
       public static DoLuong Show_DoLuong(string ma_dl)
       {
           string query = string.Format(@"SELECT * FROM KT_DOLUONG WHERE id_DL = N'{0}' ", ma_dl);
           conn = Dataprovider.moketnoi();
           DataTable dt = Dataprovider.TruyVanLayDuLieu(query, conn);
           if (dt.Rows.Count == 0)
           {
               return null;
           }
           DoLuong dl = new DoLuong();
           dl.Tg_capphat = float.Parse(dt.Rows[0]["TG_CapPhat"].ToString());
           dl.Sothetich = float.Parse(dt.Rows[0]["SoTheTich"].ToString());
           dl.Luuluong_qmax = float.Parse(dt.Rows[0]["LuuLuong_Qmax"].ToString());
           dl.ketLuan_qmax = dt.Rows[0]["KetLuan_Qmax"].ToString();

           dl.vfd_max_t1 = float.Parse(dt.Rows[0]["VFD_max_T1"].ToString());
           dl.vref_max_t1 = float.Parse(dt.Rows[0]["VREF_max_T1"].ToString());
           dl.efd_max_t1 = float.Parse(dt.Rows[0]["EFD_max_T1"].ToString());
           dl.vfd_max_t2 = float.Parse(dt.Rows[0]["VFD_max_T2"].ToString());
           dl.vref_max_t2 = float.Parse(dt.Rows[0]["VREF_max_T2"].ToString());
           dl.efd_max_t2 = float.Parse(dt.Rows[0]["EFD_max_T2"].ToString());
           dl.eav_max_s = float.Parse(dt.Rows[0]["EAV_max_T"].ToString());
           dl.Ketluan_qmax_t = dt.Rows[0]["KL_Qmax_T"].ToString();

           dl.vfd_min_t1 = float.Parse(dt.Rows[0]["VFD_min_T1"].ToString());
           dl.vref_min_t1 = float.Parse(dt.Rows[0]["VREF_min_T1"].ToString());
           dl.efd_min_t1 = float.Parse(dt.Rows[0]["EFD_min_T1"].ToString());
           dl.vfd_min_t2 = float.Parse(dt.Rows[0]["VFD_min_T2"].ToString());
           dl.vref_min_t2 = float.Parse(dt.Rows[0]["VREF_min_T2"].ToString());
           dl.efd_min_t2 = float.Parse(dt.Rows[0]["EFD_min_T2"].ToString());
           dl.eav_min_t = float.Parse(dt.Rows[0]["EAV_min_T"].ToString());
           dl.Ketluan_qmin_t = dt.Rows[0]["KL_Qmin_T"].ToString(); ;

           dl.vfd_max_s1 = float.Parse(dt.Rows[0]["VFD_max_S1"].ToString());
           dl.vref_max_s1 = float.Parse(dt.Rows[0]["VREF_max_S1"].ToString());
           dl.efd_max_s1 = float.Parse(dt.Rows[0]["EFD_max_S1"].ToString());
           dl.vfd_max_s2 = float.Parse(dt.Rows[0]["VFD_max_S2"].ToString());
           dl.vref_max_s2 = float.Parse(dt.Rows[0]["VREF_max_S2"].ToString());
           dl.efd_max_s2 = float.Parse(dt.Rows[0]["EFD_max_S2"].ToString());
           dl.eav_max_s = float.Parse(dt.Rows[0]["EAV_max_S"].ToString());
           dl.Ketluan_qmax_s = dt.Rows[0]["KL_Qmax_S"].ToString();

           dl.vfd_min_s1 = float.Parse(dt.Rows[0]["VFD_min_S1"].ToString());
           dl.vref_min_s1 = float.Parse(dt.Rows[0]["VREF_min_S1"].ToString());
           dl.efd_min_s1 = float.Parse(dt.Rows[0]["EFD_min_S1"].ToString());
           dl.vfd_min_s2 = float.Parse(dt.Rows[0]["VFD_min_S2"].ToString());
           dl.vref_min_s2 = float.Parse(dt.Rows[0]["VREF_min_S2"].ToString());
           dl.efd_min_s2 = float.Parse(dt.Rows[0]["EFD_min_S2"].ToString());
           dl.eav_min_s = float.Parse(dt.Rows[0]["EAV_min_S"].ToString());
           dl.Ketluan_qmin_s = dt.Rows[0]["KL_Qmin_S"].ToString();
           return dl;
       }
    }
}
