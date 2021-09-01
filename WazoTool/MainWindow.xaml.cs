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

namespace WazoTool
{
    
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Legacy legacy = new Legacy();
            
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            //Quit out of application
            Environment.Exit( 1 );
            //Old way just closes it from tray
            //Close();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            //Minimizes the application
            mainWindow.WindowState = WindowState.Minimized;
            mainWindow.ShowInTaskbar = true;
        }

        private void btnLegacy_Click(object sender, RoutedEventArgs e)
        {
            //Create an object from the legacy tab window
            //Then show it while hiding mainwindow
            Legacy uusilegacy = new Legacy();
            //mainWindow.TransformToAncestor(uusilegacy);
            uusilegacy.Show();
            mainWindow.Hide();
            //
        }
    }
}
