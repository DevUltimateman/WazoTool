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

namespace WazoTool
{
    /// <summary>
    /// Interaction logic for Legacy.xaml
    /// </summary>
    public partial class Legacy : Window
    {
        public Legacy()
        {
            InitializeComponent();
        }

        private void btnMainPage_Click(object sender, RoutedEventArgs e)
        {
            MainWindow paasivu = new MainWindow();

            paasivu.Show();

            legacyWindow.Hide();
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnLegacy_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
