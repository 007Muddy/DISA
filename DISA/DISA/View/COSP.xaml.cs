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
    
    public partial class COSP : Window
    {
        MainViewModel mvm = new MainViewModel();

        public COSP()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void COFinal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void COMaximum(object sender, RoutedEventArgs e)
        {

        }

        private void COMinimum(object sender, RoutedEventArgs e)
        {

        }
    }
}
