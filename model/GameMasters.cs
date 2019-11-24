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
        
        private GameMasters()
        {
            Board = Board.Instance;
        }
        
        public List<Player> Players { get; set; }
        public Player CurrentPlayer { get; set; }
        public Board Board { get; set; }

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
    }
}
