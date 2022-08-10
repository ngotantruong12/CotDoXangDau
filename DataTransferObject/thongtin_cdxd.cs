using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class thongtin_cdxd
    {
        private string id_CDXD;
        private string TenPhuongTien;//
        private int Kieu;//
        private int So;//
        private int CapChinhXac;//
        private int Nam_SX;//
        private string CoSo_SX;//
        private string CheDo_KD;//
        private DateTime Ngay_KD;//
        private float LuuLuong_Max;//
        private float LuuLuong_Min;//
        private float LuongCapPhat_Min;//
        private string ChatLong_KD;//
        private string PhuongPhap_TH;//
        private string ChuanThietBi_SD;//
        private string DonVi_SD;//
        private int id_NV;//
        private string DiaChi_SD;//
        private string DiaDiem_TH;//

        public string ID_CDXD
        {
            get { return id_CDXD; }
            set { id_CDXD = value; }
        }

        public string TENPHUONGTIEN
        {
            get { return TenPhuongTien; }
            set { TenPhuongTien = value; }
        }

        public int kieu
        {
            get { return Kieu; }
            set { Kieu = value; }
        }

        public int so
        {
            get { return So; }
            set { So = value; }
        }

        public int CAPCHINHXAC
        {
            get { return CapChinhXac; }
            set { CapChinhXac = value; }
        }

        public int NAM_SX
        {
            get { return Nam_SX; }
            set { Nam_SX = value; }
        }


        public string CS_SX
        {
            get { return CoSo_SX; }
            set { CoSo_SX = value; }
        }

        public string CHEDO_KD
        {
            get { return CheDo_KD; }
            set { CheDo_KD = value; }
        }

        public DateTime NGAY_KD
        {
            get { return Ngay_KD; }
            set { Ngay_KD = value; }
        }

        public float LUULUONG_MAX
        {
            get { return LuuLuong_Max; }
            set { LuuLuong_Max = value; }
        }

        public float LUULUONG_MIN
        {
            get { return LuuLuong_Min; }
            set { LuuLuong_Min = value; }
        }

        public float LUONGCAPPHAT_MIN
        {
            get { return LuongCapPhat_Min; }
            set { LuongCapPhat_Min = value; }
        }

        public string CHATLONG_KD
        {
            get { return ChatLong_KD; }
            set { ChatLong_KD = value; }
        }

        public string PHUONGPHAP_TH
        {
            get { return PhuongPhap_TH; }
            set { PhuongPhap_TH = value; }
        }

        public string CHUANTHIETBI_SD
        {
            get { return ChuanThietBi_SD; }
            set { ChuanThietBi_SD = value; }
        }

        public string DONVI_SD
        {
            get { return DonVi_SD; }
            set { DonVi_SD = value; }
        }

        public int ID_NV
        {
            get { return id_NV; }
            set { id_NV = value; }
        }

        public string DIACHI_SD
        {
            get { return DiaChi_SD; }
            set { DiaChi_SD = value; }
        }

        public string DIADIEM_TH
        {
            get { return DiaDiem_TH; }
            set { DiaDiem_TH = value; }
        }
    }
}
