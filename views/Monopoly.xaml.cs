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

namespace Monopoly_TD7
{
    /// <summary>
    /// Interaction logic for midWindow.xaml
    /// </summary>
    public partial class Monopoly: Window
    {
        List<Rectangle> Tiles = new List<Rectangle>();
        List<Ellipse> Tokens = new List<Ellipse>();

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

            foreach (Ellipse token in Tokens)
            {
                token.Visibility = Visibility.Visible;
            }
            Console.WriteLine(Tokens[0]);

            Canvas.SetLeft(Tokens[0], Canvas.GetLeft(Tiles[2]));
            Canvas.SetTop(Tokens[0], Canvas.GetTop(Tiles[2]));

            Canvas.SetLeft(Tokens[1], Canvas.GetLeft(Tiles[2])+10);
            Canvas.SetTop(Tokens[1], Canvas.GetTop(Tiles[2]));

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
    }
}


