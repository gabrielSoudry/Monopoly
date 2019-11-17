using Monopoly_TD7.model.Lands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Monopoly_TD7.model
{
    public sealed class Board
    {
        private static Board board;
        private static readonly object padlock = new object();
        public static Land[] lands { get; set; }

        private Board() => (board,lands) = (null,new Land[40]);
        public static Board Instance
        {
            get
            {
                lock (padlock)
                {
                    if (board == null)
                    {
                        board = new Board();
                    }
                    return board;
                }
            }
        }

        public static void setUp()
        {

            lands[0] = new StartLand();

            int[] rent = { 2, 10, 30, 90, 160, 250 };
            lands[1] = new PropertyLand(60, "Mediterranean Avenue",rent,"brown");

            int[] rent2 = { 4, 20, 60, 180, 320, 450 };
            lands[2] = new PropertyLand(60, "Baltic Avenue", rent, "brown");

            int[] rent3 = { 6, 30, 90, 270, 400, 550 };
            lands[3] = new PropertyLand(100, "Oriental Avenue", rent, "blue");

            int[] rent4 = { 6, 30, 90, 270, 400, 550 };
            lands[4] = new PropertyLand(100, "Vermont Avenue", rent, "blue");

            int[] rent5 = { 8, 40, 100, 300, 450, 600 };
            lands[5] = new PropertyLand(120, "Connecticut Avenue", rent, "blue");

            int[] rent6 = { 10, 50, 150, 450, 625, 750 };
            lands[6] = new PropertyLand(140, "St. Charles Place", rent, "pink");

            int[] rent7 = { 10, 50, 150, 450, 625, 750 };
            lands[7] = new PropertyLand(140, "States Avenue", rent, "pink");

            int[] rent8 = { 12, 60, 180, 500, 700, 900 };
            lands[8] = new PropertyLand(160, "Virginia Avenue", rent, "pink");

            int[] rent9 = { 14, 70, 200, 550, 750, 950 };
            lands[9] = new PropertyLand(180, "St. James Place", rent, "orange");

            int[] rent10 = { 14, 70, 200, 550, 750, 950 };
            lands[10] = new PropertyLand(180, "Tennessee Avenue", rent, "orange");

            int[] rent11 = { 16, 80, 220, 600, 800, 1000 };
            lands[11] = new PropertyLand(200, "New York Avenue", rent, "orange");

            int[] rent12 = { 18, 90, 250, 700, 875, 1050 };
            lands[12] = new PropertyLand(220, "Kentucky Avenue", rent, "red");

            int[] rent13 = { 18, 90, 250, 700, 875, 1050 };
            lands[13] = new PropertyLand(220, "Indiana Avenue", rent, "red");

            int[] rent14 = { 20, 100, 300, 750, 925, 1100 };
            lands[14] = new PropertyLand(240, "Illnois Avenue", rent, "red");

            int[] rent15 = { 22, 110, 330, 800, 975, 1150 };
            lands[15] = new PropertyLand(260, "Atlatic Avenue", rent, "yellow");

            int[] rent16 = { 22, 110, 330, 800, 975, 1150 };
            lands[16] = new PropertyLand(260, "Ventura Avenue", rent, "yellow");

            int[] rent17 = { 24, 120, 360, 850, 1025, 1200 };
            lands[17] = new PropertyLand(280, "Marvin Gardens", rent, "yellow");

            int[] rent18 = { 26, 130, 390, 900, 1100, 1275 };
            lands[18] = new PropertyLand(300, "Pacific Avenue", rent, "green");

            int[] rent19 = { 26, 130, 390, 900, 1100, 1275 };
            lands[19] = new PropertyLand(300, "North Carolina Avenue", rent, "green");

            int[] rent20 = { 28, 150, 450, 1000, 1200, 1400 };
            lands[20] = new PropertyLand(320, "Pennsylvania Avenue", rent, "green");

            int[] rent21 = { 35, 175, 500, 1100, 1300, 1500 };
            lands[21] = new PropertyLand(350, "Park Place", rent, "black");

            int[] rent22 = { 50, 200, 600, 1400, 1700, 2000 };
            lands[22] = new PropertyLand(400, "Boardwalk", rent, "black");

            

           


            var json = new JavaScriptSerializer().Serialize(lands);
            Console.WriteLine(json);

        }
    }
}
