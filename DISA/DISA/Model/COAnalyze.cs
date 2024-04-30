using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISA.Model
{
    public class COAnalyze
    {
        public int COSP { get; set; }
        public double COFinal { get; set; }
      
        public double Average { get; set; }
       
        public DateTime TimeStamp { get; set; }

        public override string ToString()
        {
            return TimeStamp + "," + COSP + "," + COFinal;
        }
    }
}
