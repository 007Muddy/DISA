using DISA.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DISA.ViewModel
{
    public class MainViewModel
    {
        private AnalyzeRepo analyseRepo = new AnalyzeRepo();
        private COSRepo cosRepo = new COSRepo();
        private COFinalViewModel cvm = new COFinalViewModel();

        public ObservableCollection<AnalyzeViewModel> AnalysesVM { get; set; } = new();
        public ObservableCollection<COSPViewModel> COSPVM { get; set; } = new();
       
        public MainViewModel()
        {
            //hver elementer af COAnalyse og hente alt fra analyseRepo hvor dataerne er gemt
            foreach (COAnalyze item in analyseRepo.GetAll())
            {
                AnalyzeViewModel anayzeViewModel = new(item);
                AnalysesVM.Add(anayzeViewModel);
            }
        }

    }
}
