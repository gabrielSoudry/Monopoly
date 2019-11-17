using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model
{
    sealed class GameMasters
    {
        private static GameMasters instance = null;
        private List<Player> players;
        public Board board;
        static Player currentPlayer;


        private GameMasters ()
        {
            board = new Board();
            board.setUp();
        }



        public static GameMasters Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new GameMasters();
                }
                return instance;
            }
        }
    }
}
