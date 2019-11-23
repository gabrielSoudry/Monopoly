using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model
{
    public sealed class GameMasters
    {
        private static GameMasters instance = null;
        private List<Player> players;
        public Board board;
        private Player currentPlayer;


        private GameMasters()
        {
            board = new Board();
        }

        public List<Player> Players
        {
            get
            {
                return players;
            }
            set
            {
                players = value;
            }
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
            set
            {
                instance = value;
            }
        }
      

        public Player CurrentPlayer
        {
            get
            {
                return currentPlayer;
            }
           set
            {
                currentPlayer = value;
            }
        }
        

    }
}
