﻿using Monopoly_TD7.model;
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
        List<Rectangle> Tiles = new List<Rectangle>();
        List<Ellipse> Tokens = new List<Ellipse>();
        GameMasters gameMaster = GameMasters.Instance;
        public Monopoly()
        {
            InitializeComponent();
            WindowStartupLocation = WindowStartupLocation.CenterScreen;
            addTileToList();
            addTokenToList();
        }

        public void addTokenToList()
        {
            Tokens.Add(player1);
            Tokens.Add(player2);
            Tokens.Add(player3);
            Tokens.Add(player4);

            Tokens.ForEach(t => t.Visibility = Visibility.Hidden);
            for (int i = 0; i < gameMaster.Players.Count; i++) {
                Tokens[i].Visibility = Visibility.Visible;
            }

        }


        public void playerSetPosition(int numeroPlayer, int tile)
        {
            Canvas.SetLeft(Tokens[numeroPlayer], Canvas.GetLeft(Tiles[tile])+(numeroPlayer+1)*5);
            Canvas.SetTop(Tokens[numeroPlayer], Canvas.GetTop(Tiles[tile]));
        }


        public void addTileToList()
        {

            Tiles.Add(Tile0);
            Tiles.Add(Tile1);
            Tiles.Add(Tile2);
            Tiles.Add(Tile3);
            Tiles.Add(Tile4);
            Tiles.Add(Tile5);
            Tiles.Add(Tile6);
            Tiles.Add(Tile7);
            Tiles.Add(Tile8);
            Tiles.Add(Tile9);
            Tiles.Add(Tile10);
            Tiles.Add(Tile11);
            Tiles.Add(Tile12);
            Tiles.Add(Tile13);
            Tiles.Add(Tile14);
            Tiles.Add(Tile15);
            Tiles.Add(Tile16);
            Tiles.Add(Tile17);
            Tiles.Add(Tile18);
            Tiles.Add(Tile19);
            Tiles.Add(Tile20);
            Tiles.Add(Tile21);
            Tiles.Add(Tile22);
            Tiles.Add(Tile23);
            Tiles.Add(Tile24);
            Tiles.Add(Tile25);
            Tiles.Add(Tile26);
            Tiles.Add(Tile27);
            Tiles.Add(Tile28);
            Tiles.Add(Tile29);
            Tiles.Add(Tile30);
            Tiles.Add(Tile31);
            Tiles.Add(Tile32);
            Tiles.Add(Tile33);
            Tiles.Add(Tile34);
            Tiles.Add(Tile35);
            Tiles.Add(Tile36);
            Tiles.Add(Tile37);
            Tiles.Add(Tile38);
            Tiles.Add(Tile39);
            foreach (Rectangle tile in Tiles)
            {
                tile.Visibility = Visibility.Hidden;
            }
        }

         
        private void Dice_Click(object sender, RoutedEventArgs e)
        {
            randomDie result = gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].move();

            #region Debug
            Console.WriteLine(gameMaster.CurrentPlayer.Name);
            Console.WriteLine(gameMaster.board.lands[gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition].ToString());
            Console.WriteLine(gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition);
            Console.WriteLine("===");
            #endregion

            // While the player is in jail, he still rolls the dice on his turn as usual, but does not 
            //move until either:(a) he gets aboth dice with the same value, or(b) he fails to roll both dice
            //with the same valuefor three times in a row
            //(i.e. his previous two turns after moving to jail and his current turn)

            //If either(a) or(b) happens in the player's turn, then he moves forward by the sum of the dice rolled positions and his turn ends. 
            //He doesnot roll the dice again even if he has rolled a both dice with the same value

            if (result.die1 != result.die2)
            {
                playerSetPosition(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer), gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition);
                gameMaster.CurrentPlayer.NumberOfDouble = 0;
                gameMaster.CurrentPlayer = gameMaster.Players[(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer) + 1) % gameMaster.Players.Count];
            }
            else
            {
                gameMaster.CurrentPlayer.NumberOfDouble += 1;
                if (gameMaster.CurrentPlayer.NumberOfDouble == 3)
                {
                    // Put the players on Jail ! 
                    gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition = 10;
                    gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].IsOnJail = true;
                    gameMaster.CurrentPlayer.NumberOfDouble = 0;
                    playerSetPosition(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer), gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition);

                    gameMaster.CurrentPlayer = gameMaster.Players[(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer) + 1) % gameMaster.Players.Count];
                }
                else if (gameMaster.CurrentPlayer.Release && gameMaster.CurrentPlayer.NumberOfDouble != 3)
                {
                    //He doesnot roll the dice again even if he has rolled a both dice with the same value
                    playerSetPosition(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer), gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition);
                    gameMaster.CurrentPlayer.Release = false;

                    gameMaster.CurrentPlayer = gameMaster.Players[(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer) + 1) % gameMaster.Players.Count];
                }
            }
            playerSetPosition(gameMaster.Players.IndexOf(gameMaster.CurrentPlayer), gameMaster.Players[gameMaster.Players.IndexOf(gameMaster.CurrentPlayer)].LandPosition);

            dice1.Source = new BitmapImage(new Uri(UrlImageDice(result.die1)));
            dice2.Source = new BitmapImage(new Uri(UrlImageDice(result.die2)));

        }

        public string UrlImageDice(int number)
        {
            if (number == 1) { return Directory.GetCurrentDirectory() + @"../../../img/dice1.png"; }
            else if (number == 2) { return Directory.GetCurrentDirectory() + @"../../../img/dice2.png"; }
            else if (number == 3) { return Directory.GetCurrentDirectory() + @"../../../img/dice3.png"; }
            else if (number == 4) { return Directory.GetCurrentDirectory() + @"../../../img/dice4.png"; }
            else if (number == 5) { return Directory.GetCurrentDirectory() + @"../../../img/dice5.png"; }
            else { return Directory.GetCurrentDirectory() + @"../../../img/dice6.png"; }

        }

        private void Purchase(object sender, RoutedEventArgs e)
        {
            Console.WriteLine("======");
            var land = (gameMaster.board.lands[gameMaster.Players[0].LandPosition]) as ISaleable;
            gameMaster.board.lands[gameMaster.Players[0].LandPosition].ToString();
            if (land != null)
            {
                Console.WriteLine(land.ToString());
                land.Purchase(gameMaster.Players[0]);
                Console.WriteLine(gameMaster.Players[0].Money);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var land = (gameMaster.board.lands[gameMaster.Players[0].LandPosition]) as ISaleable;
            gameMaster.board.lands[gameMaster.Players[0].LandPosition].ToString();
            if (land != null)
            {
                land.Purchase(gameMaster.Players[0]);
            }   
        }
    }
}

