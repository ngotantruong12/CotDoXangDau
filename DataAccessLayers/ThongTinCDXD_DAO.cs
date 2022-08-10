using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DataTransferObject;
using System.Data;
using DataAccessLayers;

namespace DataAccessLayers
{
   public class ThongTinCDXD_DAO
    {
        static SqlConnection Conn;
        //them thong tin
        public static bool Them_ThongTinCDXD(thongtin_cdxd tt_cdxd)
        {
            string Addquery = string.Format(@"INSERT INTO THONGTIN_CDXD VALUES (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}',N'{5}',N'{6}',N'{7}',N'{8}',N'{9}',N'{10}',N'{11}',N'{12}',N'{13}',N'{14}',N'{15}',N'{16}',N'{17}',N'{18}')"
                , tt_cdxd.ID_CDXD, tt_cdxd.TENPHUONGTIEN, tt_cdxd.kieu, tt_cdxd.so, tt_cdxd.CAPCHINHXAC, tt_cdxd.NAM_SX, tt_cdxd.CS_SX, tt_cdxd.CHEDO_KD, tt_cdxd.NGAY_KD, tt_cdxd.LUULUONG_MAX, tt_cdxd.LUULUONG_MIN, tt_cdxd.LUONGCAPPHAT_MIN, tt_cdxd.CHATLONG_KD,
                tt_cdxd.PHUONGPHAP_TH, tt_cdxd.CHUANTHIETBI_SD, tt_cdxd.DONVI_SD, tt_cdxd.ID_NV, tt_cdxd.DIACHI_SD, tt_cdxd.DIADIEM_TH);
            Conn = Dataprovider.moketnoi();
            bool result = Dataprovider.TruyVanKhongLayDuLieu(Addquery, Conn);
            return result;
        }
        public static DataTable LoadCBB()
        {
            string query = string.Format(@"SELECT * FROM  NHANVIEN_KD");
            Conn = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(query, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            return dt;
        }

        //Sua thong tin
        public static bool SuaThongTin_CDXD(thongtin_cdxd tt_cdxd, string id_cdxd)
        {

            string Editquery = string.Format(@"UPDATE THONGTIN_CDXD SET TenPhuongTien= N'{0}',Kieu= N'{1}',So= N'{2}',CapChinhXac = N'{3}', Nam_SX = N'{4}', CoSo_SX= N'{5}',CheDo_KD= N'{6}',Ngay_KD= N'{7}',LuuLuong_Max = N'{8}',LuuLuong_Min=N'{9}',LuongCapPhat_Min=N'{10}',ChatLong_KD= N'{11}',PhuongPhap_TH =N'{12}',ChuanThietBi_SD= N'{13}', DonVi_SD= N'{14}',id_NV =N'{15}',DiaChi_SD = N'{16}',DiaDiem_TH =N'{17}' WHERE id_CDXD = N'{18}'",
                tt_cdxd.TENPHUONGTIEN, tt_cdxd.kieu, tt_cdxd.so, tt_cdxd.CAPCHINHXAC, tt_cdxd.NAM_SX, tt_cdxd.CS_SX, tt_cdxd.CHEDO_KD, tt_cdxd.NGAY_KD, tt_cdxd.LUULUONG_MAX, tt_cdxd.LUULUONG_MIN, tt_cdxd.LUONGCAPPHAT_MIN, tt_cdxd.CHATLONG_KD, tt_cdxd.PHUONGPHAP_TH, tt_cdxd.CHUANTHIETBI_SD, tt_cdxd.DONVI_SD, tt_cdxd.ID_NV, tt_cdxd.DIACHI_SD, tt_cdxd.DIADIEM_TH, tt_cdxd.ID_CDXD);
            Conn = Dataprovider.moketnoi();
            bool kq = Dataprovider.TruyVanKhongLayDuLieu(Editquery, Conn);
            return kq;
        }

        //Tim thong tin
        public static thongtin_cdxd XemThongTin_CDXD(string id_cdxd)
        {
            string queryXem = string.Format(@"SELECT * FROM THONGTIN_CDXD WHERE id_CDXD = N'{0}'", id_cdxd);
            Conn = Dataprovider.moketnoi();
            DataTable dt = Dataprovider.TruyVanLayDuLieu(queryXem, Conn);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            thongtin_cdxd Xemtt_cdxd = new thongtin_cdxd();
            Xemtt_cdxd.TENPHUONGTIEN = dt.Rows[0]["TenPhuongTien"].ToString();
            Xemtt_cdxd.kieu = int.Parse(dt.Rows[0]["Kieu"].ToString());
            Xemtt_cdxd.so = int.Parse(dt.Rows[0]["So"].ToString());
            Xemtt_cdxd.CAPCHINHXAC = int.Parse(dt.Rows[0]["CapChinhXac"].ToString());
            Xemtt_cdxd.NAM_SX = int.Parse(dt.Rows[0]["Nam_SX"].ToString());
            Xemtt_cdxd.CS_SX = dt.Rows[0]["CoSo_SX"].ToString();
            Xemtt_cdxd.CHEDO_KD = dt.Rows[0]["CheDo_KD"].ToString();
            Xemtt_cdxd.NGAY_KD = DateTime.Parse(dt.Rows[0]["Ngay_KD"].ToString());
            Xemtt_cdxd.LUULUONG_MAX = float.Parse(dt.Rows[0]["LuuLuong_Max"].ToString());
            Xemtt_cdxd.LUULUONG_MIN = float.Parse(dt.Rows[0]["LuuLuong_Min"].ToString());
            Xemtt_cdxd.LUONGCAPPHAT_MIN = float.Parse(dt.Rows[0]["LuongCapPhat_Min"].ToString());
            Xemtt_cdxd.CHATLONG_KD = dt.Rows[0]["ChatLong_KD"].ToString();
            Xemtt_cdxd.PHUONGPHAP_TH = dt.Rows[0]["PhuongPhap_TH"].ToString();
            Xemtt_cdxd.CHUANTHIETBI_SD = dt.Rows[0]["ChuanThietBi_SD"].ToString();
            Xemtt_cdxd.DONVI_SD = dt.Rows[0]["DonVi_SD"].ToString();
            Xemtt_cdxd.ID_NV = int.Parse(dt.Rows[0]["id_NV"].ToString());
            Xemtt_cdxd.DIACHI_SD = dt.Rows[0]["DiaChi_SD"].ToString();
            Xemtt_cdxd.DIADIEM_TH = dt.Rows[0]["DiaDiem_TH"].ToString();
            return Xemtt_cdxd;


        }
    }
}
