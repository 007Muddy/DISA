using DISA.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DISA.ViewModel
{
    public class AnalyzeViewModel
    {
        private COAnalyze cOAnalyse;
        public DateTime TimeStamp { get; set; }
        public int COSP { get; set; }
        public double COFinal { get; set; }
        public double AverageValue { get; set; }

        public AnalyzeViewModel(COAnalyze cOAnalyse)
        {
            this.cOAnalyse = cOAnalyse;
            TimeStamp = cOAnalyse.TimeStamp;
            COFinal = cOAnalyse.COFinal;  
            COSP = cOAnalyse.COSP;
            AverageValue = cOAnalyse.Average;
        } 
    }
}
