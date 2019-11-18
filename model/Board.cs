using Monopoly_TD7.model.Lands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Monopoly_TD7.model
{
    public class Board
    {
        private static readonly object padlock = new object();
        public Land[] lands { get; set; }
    
        public Board() => (lands) = (new Land[40]);    
  
    }
}
