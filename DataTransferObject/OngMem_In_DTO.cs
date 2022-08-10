using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class OngMem_In_DTO
    {
        private string id_om_cci;
        private float so_od;
        private string kl_so_od;
        private string kt_cci;
        private float vfd_1_OD;
        private float pfd_1_OD;
        private float luuluong_GN_1;
        private float tien_tt1;
        private string ketluan_1_OD;
        private float vfd_2_OD;
        private float pfd_2_OD;
        private float luuluong_GN_2;
        private float tien_tt2;
        private string ketluan_2_OD;
        private string kt_cni;
        private string kt_nd;

        public string ID_OM_CCI
        {
            get { return id_om_cci; }
            set { id_om_cci = value; }
        }

        public float SO_OD
        {
            get { return so_od; }
            set { so_od = value; }
        }
        public string KL_SO_OD
        {
            get { return kl_so_od; }
            set { kl_so_od = value; }
        }
        public string KT_CCI
        {
            get { return kt_cci; }
            set { kt_cci = value; }
        }
        public float VFD_1_OD
        {
            get { return vfd_1_OD; }
            set { vfd_1_OD = value; }
        }

        public float PFD_1_OD
        {
            get { return pfd_1_OD; }
            set { pfd_1_OD = value; }
        }
        public float LuuLuong_GN_1
        {
            get { return luuluong_GN_1; }
            set { luuluong_GN_1 = value; }
        }
        public float Tien_TT_1
        {
            get { return tien_tt1; }
            set { tien_tt1 = value; }
        }
        public string Ket_Luan_1_OD
        {
            get { return ketluan_1_OD; }
            set { ketluan_1_OD = value; }
        }
        //
        public float VFD_2_OD
        {
            get { return vfd_2_OD; }
            set { vfd_2_OD = value; }
        }

        public float PFD_2_OD
        {
            get { return pfd_2_OD; }
            set { pfd_2_OD = value; }
        }
        public float LuuLuong_GN_2
        {
            get { return luuluong_GN_2; }
            set { luuluong_GN_2 = value; }
        }
        public float Tien_TT_2
        {
            get { return tien_tt2; }
            set { tien_tt2 = value; }
        }
        public string Ket_Luan_2_OD
        {
            get { return ketluan_2_OD; }
            set { ketluan_2_OD = value; }
        }
        //
        public string KT_CNI
        {
            get { return kt_cni; }
            set { kt_cni = value; }
        }
        public string KT_ND
        {
            get { return kt_nd; }
            set { kt_nd = value; }
        }


    }
}
