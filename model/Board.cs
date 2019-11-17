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
            lands[1] = new PropertyLand(60, "Mediterranean Avenue",rent,"purple");

            int[] rent2 = { 2, 10, 30, 90, 160, 250 };
            lands[2] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent3 = { 2, 10, 30, 90, 160, 250 };
            lands[3] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent4 = { 2, 10, 30, 90, 160, 250 };
            lands[4] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent5 = { 2, 10, 30, 90, 160, 250 };
            lands[5] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent6 = { 2, 10, 30, 90, 160, 250 };
            lands[6] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent7 = { 2, 10, 30, 90, 160, 250 };
            lands[7] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent8 = { 2, 10, 30, 90, 160, 250 };
            lands[8] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent9 = { 2, 10, 30, 90, 160, 250 };
            lands[9] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent10 = { 2, 10, 30, 90, 160, 250 };
            lands[10] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent11 = { 2, 10, 30, 90, 160, 250 };
            lands[11] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent12 = { 2, 10, 30, 90, 160, 250 };
            lands[12] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent13 = { 2, 10, 30, 90, 160, 250 };
            lands[13] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent14 = { 2, 10, 30, 90, 160, 250 };
            lands[14] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent15 = { 2, 10, 30, 90, 160, 250 };
            lands[15] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent16 = { 2, 10, 30, 90, 160, 250 };
            lands[16] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent17 = { 2, 10, 30, 90, 160, 250 };
            lands[17] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent18 = { 2, 10, 30, 90, 160, 250 };
            lands[18] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent19 = { 2, 10, 30, 90, 160, 250 };
            lands[19] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent20 = { 2, 10, 30, 90, 160, 250 };
            lands[20] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent21 = { 2, 10, 30, 90, 160, 250 };
            lands[21] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent22 = { 2, 10, 30, 90, 160, 250 };
            lands[22] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent23 = { 2, 10, 30, 90, 160, 250 };
            lands[23] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent24 = { 2, 10, 30, 90, 160, 250 };
            lands[24] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent25 = { 2, 10, 30, 90, 160, 250 };
            lands[25] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent26 = { 2, 10, 30, 90, 160, 250 };
            lands[26] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent27 = { 2, 10, 30, 90, 160, 250 };
            lands[27] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent28 = { 2, 10, 30, 90, 160, 250 };
            lands[28] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent29 = { 2, 10, 30, 90, 160, 250 };
            lands[29] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent30 = { 2, 10, 30, 90, 160, 250 };
            lands[30] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent31 = { 2, 10, 30, 90, 160, 250 };
            lands[31] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent32 = { 2, 10, 30, 90, 160, 250 };
            lands[32] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent33 = { 2, 10, 30, 90, 160, 250 };
            lands[33] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent34 = { 2, 10, 30, 90, 160, 250 };
            lands[34] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent35 = { 2, 10, 30, 90, 160, 250 };
            lands[35] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent36 = { 2, 10, 30, 90, 160, 250 };
            lands[36] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent37 = { 2, 10, 30, 90, 160, 250 };
            lands[37] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent38 = { 2, 10, 30, 90, 160, 250 };
            lands[38] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent39 = { 2, 10, 30, 90, 160, 250 };
            lands[39] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

            int[] rent40= { 2, 10, 30, 90, 160, 250 };
            lands[40] = new PropertyLand(60, "Mediterranean Avenue", rent, "purple");

           


            var json = new JavaScriptSerializer().Serialize(lands);
            Console.WriteLine(json);

        }
    }
}
