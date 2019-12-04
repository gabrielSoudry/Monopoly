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
        private static Board instance;
        public Land[] lands { get; set; }
    
        private Board() => (lands) = (new Land[40]);

        public static Board Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Board();
                }
                return instance;
            }
        }

    }
}
