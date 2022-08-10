using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTransferObject
{
    
    public class KTNgoai_DTO
    {
       private String id_BN;
       private String KT_NhanMac;
       private String KT_BoPhanChinh;
       private String KT_Kinh;
       private String KT_OngCS;



       public String id_bn
       {
           get { return id_BN; }
           set { id_BN = value; }
       }

       public String KT_nhanmac
       {
           get { return KT_NhanMac; }
           set { KT_NhanMac = value; }
       }

       public String KT_bophanchinh
       {
           get { return KT_BoPhanChinh; }
           set { KT_BoPhanChinh = value; }
       }

       public String KT_kinh
       {
           get { return KT_Kinh; }
           set { KT_Kinh = value; }
       }
       public String KT_ongcs
       {
           get { return KT_OngCS; }
           set { KT_OngCS = value; }
       }


        
    }


}
