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
            lands[0] = new PropertyLand();
            lands[1] = new PropertyLand();
        }
    }
}
