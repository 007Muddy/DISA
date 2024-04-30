using DISA.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DISA
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainViewModel mvm = new MainViewModel();
        public MainWindow()
        {
            InitializeComponent();
            DataContext = mvm;
        }

        private void COSP_Click(object sender, RoutedEventArgs e)
        {
            COSP cospWin = new COSP();
            cospWin.Show();

        }

        private void COFinal_Click(object sender, RoutedEventArgs e)
        {
            COFinal cOFinal = new COFinal();
            cOFinal.Show();
        }
    }
}
