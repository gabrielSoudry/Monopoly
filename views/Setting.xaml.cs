using Monopoly_TD7.model;
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

namespace Monopoly_TD7
{
    /// <summary>
    /// Logique d'interaction pour Setting.xaml
    /// </summary>
    public partial class Setting : Window
    {
        public Setting()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            string path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"board.json");
            string files = File.ReadAllText(path);
            Console.WriteLine(files);

            // We deserialize the gameMaster with the board via json file to avoid to have all the initizialisation in our code 
            GameMasters game = JsonConvert.DeserializeObject<GameMasters>(files, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.Auto
            });
            GameMasters.Instance = game;
            int nbPlayers = Int32.Parse(cboPickOne.SelectedValue.ToString());
            List<Player> players = new List<Player>(new Player[] { new Player("Player 1"), new Player("Player 2") });

            Player player3 = new Player("Player 3");
            Player player4 = new Player("Player 4");
            
            if (nbPlayers == 3 || nbPlayers ==4) { players.Add(player3); }
            if (nbPlayers == 4) { players.Add(player4); }

            game.Players=players;
            
            Console.WriteLine(game.Players[1].Name);

            Monopoly a = new Monopoly();
            this.Close();
            a.Show();
        }   
    }
}
