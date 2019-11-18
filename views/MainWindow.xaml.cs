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
        GameMasters game;
        List<Player> players;
        Board board;

        Player currentPlayer;
        
        public MainWindow()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        void StartMonopoly(object sender, RoutedEventArgs e)
        {
            Setting setting = new Setting();
            setting.Show();

            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"board.json");
            Console.WriteLine(path);
            string files = File.ReadAllText(path);

            GameMasters game = JsonConvert.DeserializeObject<GameMasters>(files, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });

            Console.WriteLine("==============");
            Console.WriteLine(game.board.lands[1].ToString());
            Console.WriteLine("==============");
          
            this.Close();
           
            /*
            Numplayers numplayer = new Numplayers(1);
            numplayer.Show();
            game = GameController.Instance;
            board = game.board;
            players = game.players;
            lands = game.board.lands;

            currentPlayer = game.currentPlayer();
            this.Close();
    */
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
