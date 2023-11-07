using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPackApp
{
	public class Bow : InventoryItem
	{
        public Bow(double weight = 1, double volume = 4) 
            : base(weight, volume)
        {

        }
    }
}
