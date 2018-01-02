using DBEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebThiB1Online.Areas.admin.Models
{
    public class CauHoi
    {
        public int ID { get; set; }
        public string TieuDe { get; set; }
        public string DapAnA { get; set; }
        public string DapAnB { get; set; }
        public string DapAnC { get; set; }
        public string DapAnD { get; set; }
        public string DapAn { get; set; }
        private static List<CauHoi> lst = LayDSCauHoi(1);
        public static  List<CauHoi> LayDSCauHoi(int MaTopic)
        {
            List<CauHoi> lstTam = new List<CauHoi>();
            using (B1OnlineEntities context = new B1OnlineEntities())
            {
               var c= context.CauHois.ToList
            };
            return lstTam;
        }
        public static bool deleteCauHoi(int ID)
        {
            int i = CauHoi.lst.FindIndex(x => x.ID == ID);
            if (i > -1)
            {
                CauHoi.lst.RemoveAt(i);
                return true;
            }
            else return false;
        }
    }
  

}