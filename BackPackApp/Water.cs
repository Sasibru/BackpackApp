using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPackApp
{
	internal class Water : InventoryItem
	{
        public Water(double weight = 2, double volume = 3) 
              : base(weight, volume)
        {
            
        }
    }
}
