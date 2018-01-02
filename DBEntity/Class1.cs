using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBEntity
{
    public class Class1
    {
        public static List<CauHoi> getDSCauHoiDocPart1()
        {
            using (B1OnlineEntities context = new B1OnlineEntities())
            {
                return context.CauHois.ToList();
            }
        }
        static void Main(string[] args)
        {
            // Display the number of command line arguments:
            using (B1OnlineEntities context = new B1OnlineEntities())
            {

                System.Console.WriteLine(context.CauHois.ToList());

            }
        }
    }
}
