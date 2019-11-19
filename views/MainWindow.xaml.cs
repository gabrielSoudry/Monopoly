using Monopoly_TD7.model;
using Monopoly_TD7.model.Lands;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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

namespace Monopoly_TD7
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    { 
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        void StartMonopoly(object sender, RoutedEventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();
            this.Close();
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
