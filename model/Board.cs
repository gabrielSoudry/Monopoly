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

            int[] rent1 = { 2, 10, 30, 90, 160, 250 };
            lands[1] = new PropertyLand(60, "Mediterranean Avenue",rent1,"brown");

            lands[2] = new CommunityChestLand();

            int[] rent2 = { 4, 20, 60, 180, 320, 450 };
            lands[3] = new PropertyLand(60, "Baltic Avenue", rent2, "brown");

            lands[4] = new TaxLand("Income Tax",200);

            lands[5] = new RailRoadLand("Reading Railroad",200);

            int[] rent3 = { 6, 30, 90, 270, 400, 550 };
            lands[6] = new PropertyLand(100, "Oriental Avenue", rent3, "blue");

            lands[7] = new ChanceLand();

            int[] rent4 = { 6, 30, 90, 270, 400, 550 };
            lands[8] = new PropertyLand(100, "Vermont Avenue", rent4, "blue");

            int[] rent5 = { 8, 40, 100, 300, 450, 600 };
            lands[9] = new PropertyLand(120, "Connecticut Avenue", rent5, "blue");

            lands[10] = new JailLand();

            lands[11] = new CompanyLand("Electric Company",150);

            int[] rent6 = { 10, 50, 150, 450, 625, 750 };
            lands[12] = new PropertyLand(140, "St. Charles Place", rent6, "pink");

            int[] rent7 = { 10, 50, 150, 450, 625, 750 };
            lands[13] = new PropertyLand(140, "States Avenue", rent7, "pink");

            lands[14] = new RailRoadLand("Pensylvania Railroad", 200);

            int[] rent8 = { 12, 60, 180, 500, 700, 900 };
            lands[15] = new PropertyLand(160, "Virginia Avenue", rent8, "pink");

            lands[16] = new CommunityChestLand();

            int[] rent9 = { 14, 70, 200, 550, 750, 950 };
            lands[17] = new PropertyLand(180, "St. James Place", rent9, "orange");

            int[] rent10 = { 14, 70, 200, 550, 750, 950 };
            lands[18] = new PropertyLand(180, "Tennessee Avenue", rent10, "orange");


            int[] rent11 = { 16, 80, 220, 600, 800, 1000 };
            lands[19] = new PropertyLand(200, "New York Avenue", rent11, "orange");


            lands[20] = new FreeParkLand();

            int[] rent12 = { 18, 90, 250, 700, 875, 1050 };
            lands[21] = new PropertyLand(220, "Kentucky Avenue", rent12, "red");

            lands[22] = new ChanceLand();

            int[] rent13 = { 18, 90, 250, 700, 875, 1050 };
            lands[23] = new PropertyLand(220, "Indiana Avenue", rent13, "red");

            int[] rent14 = { 20, 100, 300, 750, 925, 1100 };
            lands[24] = new PropertyLand(240, "Illnois Avenue", rent14, "red");

            lands[25] = new RailRoadLand("B. & O. Railroad", 200);

            int[] rent15 = { 22, 110, 330, 800, 975, 1150 };
            lands[26] = new PropertyLand(260, "Atlatic Avenue", rent15, "yellow");

            int[] rent16 = { 22, 110, 330, 800, 975, 1150 };
            lands[27] = new PropertyLand(260, "Ventura Avenue", rent16, "yellow");

            lands[28] = new CompanyLand("Water Works", 150);

            int[] rent17 = { 24, 120, 360, 850, 1025, 1200 };
            lands[29] = new PropertyLand(280, "Marvin Gardens", rent17, "yellow");

            lands[30] = new GoToJailLand();

            int[] rent18 = { 26, 130, 390, 900, 1100, 1275 };
            lands[31] = new PropertyLand(300, "Pacific Avenue", rent18, "green");

            int[] rent19 = { 26, 130, 390, 900, 1100, 1275 };
            lands[32] = new PropertyLand(300, "North Carolina Avenue", rent19, "green");

            lands[33] = new CommunityChestLand();

            int[] rent20 = { 28, 150, 450, 1000, 1200, 1400 };
            lands[34] = new PropertyLand(320, "Pennsylvania Avenue", rent20, "green");

            lands[35] = new RailRoadLand("Shortline",200);

            lands[36] = new ChanceLand();

            int[] rent21 = { 35, 175, 500, 1100, 1300, 1500 };
            lands[37] = new PropertyLand(350, "Park Place", rent21, "black");

            lands[38] = new TaxLand("Luxury Tax", 100);

            int[] rent22 = { 50, 200, 600, 1400, 1700, 2000 };
            lands[39] = new PropertyLand(400, "Boardwalk", rent22, "black");

            

           


            var json = new JavaScriptSerializer().Serialize(lands);
            Console.WriteLine(json);

        }
    }
}
