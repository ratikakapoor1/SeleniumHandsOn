using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementation
{
   public class InitialDemoSpecs
    {

        public static int n1 { get; set; }
        public static int sum { get; set; }
        
        public static int SetValues(int p0)
        {
            
            sum = sum + p0;
            return sum;
        }

        public static void CleanUp()
        {
            sum = 0;
        }

    }
}
