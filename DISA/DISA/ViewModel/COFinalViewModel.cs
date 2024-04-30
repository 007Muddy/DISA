using DISA.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISA.ViewModel
{
    public class COFinalViewModel
    {
        public COAnalyze cOAnalyse;
     
        private COFinalRepo coFinalRepo = new COFinalRepo();
        public ObservableCollection<COFinalViewModel> COFinalVM { get; set; } = new();
        public int COFinal { get; set; }
        public DateTime TimeStamp { get; set; }

        public COFinalViewModel(COAnalyze cOAnalyse)
        {
            this.cOAnalyse = cOAnalyse;
            COFinal = cOAnalyse.COSP;
            TimeStamp = cOAnalyse.TimeStamp;
        }

        public COFinalViewModel()
        {
        }

        public void getData()
        {
            foreach (COAnalyze item in coFinalRepo.GetAllCOSP())
            {
                COFinalViewModel cOFinal = new(item);
                COFinalVM.Add(cOFinal);

            }
        }

        //CoFinal min,max and average 
        public IEnumerable<COAnalyze> COFinalMinValue()
        {
            COAnalyze co = new COAnalyze()
            {
                COFinal = coFinalRepo.GetAllCOSP().Min(r => r.COFinal)
            };
            return new List<COAnalyze>() { co };
        }
        public IEnumerable<COAnalyze> COFinalMaxValue()
        {
            COAnalyze co = new COAnalyze()
            {
                COFinal = coFinalRepo.GetAllCOSP().Max(r => r.COFinal)
            };
            return new List<COAnalyze>() { co };
        }
        public IEnumerable<COAnalyze> COFinalAverage()
        {
            COAnalyze co = new COAnalyze()
            {
                Average = coFinalRepo.GetAllCOSP().Average(r => r.COFinal)
            };

            return new List<COAnalyze>() { co };
        }
        public void FinalMin()
        {
            COFinalMinValue();
        }
        public void FinalMax()
        {
            COFinalMaxValue();
        }
        public void FinalAverage()
        {
            COFinalAverage();
        }
    }
}
