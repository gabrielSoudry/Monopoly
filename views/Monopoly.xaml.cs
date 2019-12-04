using Monopoly_TD7.model;
using Monopoly_TD7.model.Lands;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using static Monopoly_TD7.model.RollingDie;


namespace Monopoly_TD7
{
    /// <summary>
    /// Interaction logic for midWindow.xaml
    /// </summary>
    public partial class Monopoly : Window
    {
        readonly List<Rectangle> Tiles = new List<Rectangle>();
        readonly List<Ellipse> Tokens = new List<Ellipse>();
        GameMasters gameMaster = GameMasters.Instance;
        Player lastPlayer;

        public Monopoly()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            addTileToList();
            addTokenToList();
        }

        public void addTokenToList()
        {
            Tokens.AddRange(new List<Ellipse> { player1, player2, player3, player4 });
         
            Tokens.ForEach(t => t.Visibility = Visibility.Hidden);
            for (int i = 0; i < gameMaster.Players.Count; i++) {
                Tokens[i].Visibility = Visibility.Visible;
            }
        }


        public void playerSetPosition(int numeroPlayer, int tile)
        {
            // the shift with numeroPlayer allow  to have multiple "token" on the same tiles (and not superimpose!)
            Canvas.SetLeft(Tokens[numeroPlayer], Canvas.GetLeft(Tiles[tile])+(numeroPlayer+1)*5); 
            Canvas.SetTop(Tokens[numeroPlayer], Canvas.GetTop(Tiles[tile]));
        }


        public void addTileToList()
        {
            Tiles.AddRange(new List<Rectangle> { Tile0, Tile1, Tile2, Tile3, Tile4, Tile5, Tile6, Tile7, Tile8, Tile9, Tile10, Tile11, Tile12, Tile13, Tile14, Tile15, Tile16, Tile17, Tile18,Tile19, Tile20,
                                                 Tile21,Tile22,Tile23,Tile24,Tile25,Tile26,Tile27,Tile28,Tile29,Tile30,Tile31,Tile32,Tile33,Tile34,Tile35,Tile36,Tile37,Tile38,Tile39});
            foreach (Rectangle tile in Tiles)
            {
                tile.Visibility = Visibility.Hidden;
            }
        }

         
        private void Dice_Click(object sender, RoutedEventArgs e)
        {
            randomDie result = gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].move();

            //Console.WriteLine(gameMaster.CurrentPlayer.Name);
            //Console.WriteLine(gameMaster.Board.lands[gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition].ToString());
            //Console.WriteLine("===");

            // While the player is in jail, he still rolls the dice on his turn as usual, but does not 
            //move until either:(a) he gets aboth dice with the same value, or(b) he fails to roll both dice
            //with the same valuefor three times in a row
            //(i.e. his previous two turns after moving to jail and his current turn)

            //If either(a) or(b) happens in the player's turn, then he moves forward by the sum of the dice rolled positions and his turn ends. 
            //He doesnot roll the dice again even if he has rolled a both dice with the same value

            if (result.die1 != result.die2)
            {
                // If the die ar not the same, we move the players and we pass the turn
                playerSetPosition(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer), gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition);
                gameMaster.CurrentPlayer.NumberOfDouble = 0;
                lastPlayer = gameMaster.CurrentPlayer;
                gameMaster.CurrentPlayer = gameMaster.Players[(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer) + 1) % gameMaster.Players.Count];
            }
            else
            {
                // If the die are the same
                gameMaster.CurrentPlayer.NumberOfDouble += 1;
                if (gameMaster.CurrentPlayer.NumberOfDouble == 3)
                {
                    // If it's the third time he make double we put the players on Jail and pass the turn of the player ! 
                    gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition = 10;
                    gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].IsOnJail = true;
                    gameMaster.CurrentPlayer.NumberOfDouble = 0;
                    playerSetPosition(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer), gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition);
                    lastPlayer = gameMaster.CurrentPlayer;
                    gameMaster.CurrentPlayer = gameMaster.Players[(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer) + 1) % gameMaster.Players.Count];
                }
                else if (gameMaster.CurrentPlayer.Release && gameMaster.CurrentPlayer.NumberOfDouble != 3)
                {
                    // If the player is on jail and make an double, we release the player from jail.
                    // He doesnot roll the dice again even if he has rolled a both dice with the same value
                    playerSetPosition(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer), gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition);
                    gameMaster.CurrentPlayer.Release = false;
                    lastPlayer = gameMaster.CurrentPlayer;
                    gameMaster.CurrentPlayer = gameMaster.Players[(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer) + 1) % gameMaster.Players.Count];
                }
            }
            playerSetPosition(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer), gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition);

            dice1.Source = new BitmapImage(new Uri(UrlImageDice(result.die1)));
            dice2.Source = new BitmapImage(new Uri(UrlImageDice(result.die2)));
        }

        public string UrlImageDice(int number)
        {
            if (number == 1) { return Directory.GetCurrentDirectory() + @"../../../res/img/dice1.png"; }
            else if (number == 2) { return Directory.GetCurrentDirectory() + @"../../../res/img/dice2.png"; }
            else if (number == 3) { return Directory.GetCurrentDirectory() + @"../../../res/img/dice3.png"; }
            else if (number == 4) { return Directory.GetCurrentDirectory() + @"../../../res/img/dice4.png"; }
            else if (number == 5) { return Directory.GetCurrentDirectory() + @"../../../res/img/dice5.png"; }
            else { return Directory.GetCurrentDirectory() + @"../../../res/img/dice6.png"; }
        }

        private void Purchase(object sender, RoutedEventArgs e)
        {
            if (gameMaster.Board.lands[gameMaster.Players[gameMaster.Players.IndexOf(lastPlayer)].LandPosition].SealableStrategy.
                                        Purchase(gameMaster.Players[gameMaster.Players.IndexOf(lastPlayer)]))
            { 
                Console.WriteLine("done ! ");
            }
            else
            {
                Console.WriteLine("Not purchasable land ! (Not buyable land / already bought by another player ");
            }
        }
    }
}

