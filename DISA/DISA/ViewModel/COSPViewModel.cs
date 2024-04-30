using DISA.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISA.ViewModel
{
    public class COSPViewModel
    {

        public COAnalyze cOAnalyse;
        private COSRepo cOSRepo = new COSRepo();
        public int COSP { get; set; }
        public DateTime TimeStamp { get; set; }

        public COSPViewModel(COAnalyze cOAnalyse)
        {
            this.cOAnalyse = cOAnalyse;
            COSP = cOAnalyse.COSP;
            TimeStamp = cOAnalyse.TimeStamp;
        }

        public IEnumerable<COAnalyze> COSPMinValue()
        {
            COAnalyze co = new COAnalyze()
            {
                COSP = cOSRepo.GetAll().Min(r => r.COSP)
            };

            return new List<COAnalyze>() { co };
        }

        public IEnumerable<COAnalyze> COSPMaxValue()
        {
            COAnalyze co = new COAnalyze()
            {
                COSP = cOSRepo.GetAll().Max(r => r.COSP)
            };

            return new List<COAnalyze>() { co };
        }

        public IEnumerable<COAnalyze> COSPAverage()
        {

            COAnalyze co = null;
  
            co = new COAnalyze()
            {
                Average = cOSRepo.GetAll().Average(r => r.COSP)
            };

            return new List<COAnalyze>() { co };

        }

        //COSP Repository
        public void CospMin()
        {
            COSPMinValue();
        }
        public void CospMax()
        {
            COSPMaxValue();
        }

        public void CospAverage()
        {
            COSPAverage();
        }
    }
}

