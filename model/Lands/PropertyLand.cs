using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly_TD7.model.Lands
{
    class PropertyLand : Land
    {
        public double Price { get; set; }
        public String Name { get; set; }

        public PropertyLand ()=> (Type) = (LandType.Property);

    }
}
