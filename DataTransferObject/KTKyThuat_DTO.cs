using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    public class KTKyThuat_DTO
    {
        private string id_KT;
        private string KT_SoBo;
        private string KT_DoKin;
        private string KT_HoaDongCCXS;
        private string KT_CoCauTuNgat;

        public String id_kt
        {
            get { return id_KT; }
            set { id_KT = value; }
        }
        public String kt_sobo
        {
            get { return KT_SoBo; }
            set { KT_SoBo = value; }
        }
        public String kt_dokin
        {
            get { return KT_DoKin; }
            set { KT_DoKin = value; }
        }
        public String kt_hoatdongccxs
        {
            get { return KT_HoaDongCCXS; }
            set { KT_HoaDongCCXS = value; }
        }
        public String kt_cocautungat
        {
            get { return KT_CoCauTuNgat ; }
            set { KT_CoCauTuNgat = value; }
        }



    }
}
