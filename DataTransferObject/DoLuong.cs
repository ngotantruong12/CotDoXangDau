using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class DoLuong
    {
        private string ID_DoLuong ;
        private float TG_CapPhat;
        private float SoTheTich;
        private float LuuLuong_Qmax;
        private string KetLuan_Qmax;
        private float VFD_max_T1;
        private float VREF_max_T1;
        private float EFD_max_T1;
        private float VFD_max_T2;
        private float VREF_max_T2;
        private float EFD_max_T2;
        private float DelTa_EFD_maxT;
        private float EAV_max_T;
        private string KL_Qmax_T;
        private float VFD_min_T1;
        private float VREF_min_T1;
        private float EFD_min_T1;
        private float VFD_min_T2;
        private float VREF_min_T2;
        private float EFD_min_T2;
        private float DelTa_EFD_minT;
        private float EAV_min_T;
        private string KL_Qmin_T;
        private float VFD_max_S1;
        private float VREF_max_S1;
        private float EFD_max_S1;
        private float VFD_max_S2;
        private float VREF_max_S2;
        private float EFD_max_S2;
        private float DelTa_EFD_maxS;
        private float EAV_max_S;
        private string KL_Qmax_S;
        private float VFD_min_S1;
        private float VREF_min_S1;
        private float EFD_min_S1;
        private float VFD_min_S2;
        private float VREF_min_S2;
        private float EFD_min_S2;
        private float DelTa_EFD_minS;
        private float EAV_min_S;
        private string KL_Qmin_S;

        public string Id_doluong
        {
            get { return ID_DoLuong; }
            set { ID_DoLuong = value; }
        }

        public float Tg_capphat
        {
            get { return TG_CapPhat; }
            set { TG_CapPhat = value; }
        }

        public float Sothetich
        {
            get { return SoTheTich; }
            set {SoTheTich  = value; }
        }
        public float Luuluong_qmax
        {
            get { return LuuLuong_Qmax; }
            set { LuuLuong_Qmax = value; }
        }
        public string ketLuan_qmax
        {
            get { return KetLuan_Qmax; }
            set { KetLuan_Qmax = value; }
        }

        // max t
        public float vfd_max_t1
        {
            get { return VFD_max_T1; }
            set { VFD_max_T1 = value; }
        }
        public float vref_max_t1
        {
            get { return VREF_max_T1; }
            set { VREF_max_T1 = value; }
        }

        public float efd_max_t1
        {
            get { return EFD_max_T1; }
            set { EFD_max_T1 = value; }
        }
//
        public float vfd_max_t2
        {
            get { return VFD_max_T2; }
            set { VFD_max_T2 = value; }
        }
        public float vref_max_t2
        {
            get { return VREF_max_T2; }
            set { VREF_max_T2 = value; }
        }

        public float efd_max_t2
        {
            get { return EFD_max_T2; }
            set { EFD_max_T2 = value; }
        }
        public float delta_EFD_maxT
        {
            get { return DelTa_EFD_maxT; }
            set { DelTa_EFD_maxT = value; }
        }
         public float eav_max_t
        {
            get { return EAV_max_T; }
            set { EAV_max_T = value; }
        }
         public string Ketluan_qmax_t
        {
            get { return KL_Qmax_T; }
            set { KL_Qmax_T = value; }
        }
        // min truoc 

         public float vfd_min_t1
        {
            get { return VFD_min_T1; }
            set { VFD_min_T1 = value; }
        }
        public float vref_min_t1
        {
            get { return VREF_min_T1; }
            set { VREF_min_T1 = value; }
        }

        public float efd_min_t1
        {
            get { return EFD_min_T1; }
            set { EFD_min_T1 = value; }
        }
         //
         public float vfd_min_t2
        {
            get { return VFD_min_T2; }
            set { VFD_min_T2 = value; }
        }
        public float vref_min_t2
        {
            get { return VREF_min_T2; }
            set { VREF_min_T2 = value; }
        }

        public float efd_min_t2
        {
            get { return EFD_min_T2; }
            set { EFD_min_T2 = value; }
        }
        public float delta_EFD_minT
        {
            get { return DelTa_EFD_minT; }
            set { DelTa_EFD_minT = value; }
        }
         public float eav_min_t
        {
            get { return EAV_min_T; }
            set { EAV_min_T = value; }
        }
         public string Ketluan_qmin_t
        {
            get { return KL_Qmin_T; }
            set { KL_Qmin_T = value; }
        }  

        // max sau

         public float vfd_max_s1
        {
            get { return VFD_max_S1; }
            set { VFD_max_S1 = value; }
        }
        public float vref_max_s1
        {
            get { return VREF_max_S1; }
            set { VREF_max_S1= value; }
        }

        public float efd_max_s1
        {
            get { return EFD_max_S1; }
            set { EFD_max_S1 = value; }
        } 
        //
           public float vfd_max_s2
        {
            get { return VFD_max_S2; }
            set { VFD_max_S2 = value; }
        }
        public float vref_max_s2
        {
            get { return VREF_max_S2; }
            set { VREF_max_S2 = value; }
        }

        public float efd_max_s2
        {
            get { return EFD_max_S2; }
            set { EFD_max_S2 = value; }
        }
        public float delta_EFD_maxS
        {
            get { return DelTa_EFD_maxS; }
            set { DelTa_EFD_maxS = value; }
        }
         public float eav_max_s
        {
            get { return EAV_max_S; }
            set { EAV_max_S = value; }
        }
         public string Ketluan_qmax_s
        {
            get { return KL_Qmax_S; }
            set { KL_Qmax_S = value; }
        }

        // min sau
        public float vfd_min_s1
        {
            get { return VFD_min_S1; }
            set { VFD_min_S1 = value; }
        }
        public float vref_min_s1
        {
            get { return VREF_min_S1; }
            set { VREF_min_S1 = value; }
        }

        public float efd_min_s1
        {
            get { return EFD_min_S1; }
            set { EFD_min_S1 = value; }
        }
        //
         public float vfd_min_s2
        {
            get { return VFD_min_S2; }
            set { VFD_min_S2 = value; }
        }
        public float vref_min_s2
        {
            get { return VREF_min_S2; }
            set { VREF_min_S2 = value; }
        }

        public float efd_min_s2
        {
            get { return EFD_min_S2; }
            set { EFD_min_S2 = value; }
        }
        public float delta_EFD_minS
        {
            get { return DelTa_EFD_minS; }
            set { DelTa_EFD_minS = value; }
        }
         public float eav_min_s
        {
            get { return EAV_min_S; }
            set { EAV_min_S = value; }
        }
         public string Ketluan_qmin_s
        {
            get { return KL_Qmin_S; }
            set { KL_Qmin_S = value; }
        }  


    }
}

