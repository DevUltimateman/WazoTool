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
    
    public partial class MainWindow : Window
    {
        public static System.Timers.Timer atimer = new System.Timers.Timer(500);

        public MainWindow()
        {
            InitializeComponent();
            mainWindow.ShowInTaskbar = false;
            


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
            //Also add animation ( opacity fade in )
            //Legacy uusilegacy = new Legacy();

            Legacy uusilegacy = new Legacy();

            uusilegacy.Opacity = 0;
            uusilegacy.Show();
            uusilegacy.ShowInTaskbar = false;
            DoubleAnimation ani = new DoubleAnimation(8, TimeSpan.FromSeconds(2));
            uusilegacy.BeginAnimation(Legacy.OpacityProperty, ani);

            if ( uusilegacy.Opacity == 1 )
            {
                
                mainWindow.Hide();
                mainWindow.Close();
                
                //mainWindow.Close();
                mainWindow.ShowInTaskbar = false;
                Environment.Exit(1);
            }
            
            
            
            
        }

        

        private void Lol_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnDiscord_Click(object sender, RoutedEventArgs e)
        {
            //Discord link & command executes
            var tiscord = new ProcessStartInfo("https://discord.gg/8bzK5Hu");
            tiscord.UseShellExecute = true;
            tiscord.Verb = "open";

            Process.Start(tiscord);
        }

        private void btnCommunity_Click(object sender, RoutedEventArgs e)
        {
            
            //Create new instanse of  community window
            Community uusicommunity = new Community();

            uusicommunity.Opacity = 0;
            uusicommunity.Show();
            uusicommunity.ShowInTaskbar = false;
            DoubleAnimation ani = new DoubleAnimation(8, TimeSpan.FromSeconds(2));
            uusicommunity.BeginAnimation(Community.OpacityProperty, ani);
            
            if ( uusicommunity.Opacity == 1 )
            {
                mainWindow.Hide();
                mainWindow.Close();
            }
            

            

        }

        private void btnWazoMain_Click(object sender, RoutedEventArgs e)
        {
            Legacy legikkuna = new Legacy();
            Community com = new Community();
            
            
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

                legikkuna.Close();
                com.Close();
                
            }

        }
    }
}
