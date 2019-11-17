using Monopoly_TD7.model;
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
            game = GameMasters.Instance;
            

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
