using DISA.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DISA.View
{
    /// <summary>
    /// Interaction logic for COFinal.xaml
    /// </summary>
    public partial class COFinal : Window
    {
        MainViewModel mvm = new MainViewModel();
        public COFinal()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void COAverage_Click(object sender, RoutedEventArgs e)
        {

        }

        private void COMaximum_Click(object sender, RoutedEventArgs e)
        {

        }

        private void COMinimum_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
