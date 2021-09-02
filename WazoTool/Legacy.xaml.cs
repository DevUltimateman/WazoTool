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

using System.Web;
using System.IO;
using System.Diagnostics;
using System.Threading;
using System.Windows.Threading;
using System.Timers;

using System.Windows.Media.Animation;
using System.Windows.Media.Effects;

namespace WazoTool
{
    /// <summary>
    /// Interaction logic for Legacy.xaml
    /// </summary>
    public partial class Legacy : Window
    {
        private static System.Timers.Timer aTimer;


        public Legacy()
        {
            InitializeComponent();
            legacyWindow.ShowInTaskbar = false;
        }

        private void btnWazoMain_Click(object sender, RoutedEventArgs e)
        {
            Legacy legikkuna = new Legacy();
            Community com = new Community();
            MainWindow mainWindow = new MainWindow();


            //MainWindow mainikkuna = new MainWindow();
            mainWindow.Opacity = 0;
            mainWindow.Show();
            mainWindow.ShowInTaskbar = false;
            DoubleAnimation ani = new DoubleAnimation(8, TimeSpan.FromSeconds(2));
            mainWindow.BeginAnimation(MainWindow.OpacityProperty, ani);

            if (mainWindow.Opacity == 1)
            {
                legikkuna.ShowInTaskbar = false;
                com.ShowInTaskbar = false;

                legikkuna.Hide();
                com.Hide();
                legikkuna.Close();
                com.Close();
                Environment.Exit(1);

            }
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(1);
        }

        private void btnLegacyMinimize_Click(object sender, RoutedEventArgs e)
        {
            legacyWindow.WindowState = WindowState.Minimized;
            legacyWindow.ShowInTaskbar = true;
            MainWindow maan = new MainWindow();
            maan.Close();
            maan.Hide();
        }
    }
}
