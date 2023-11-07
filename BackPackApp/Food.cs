using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPackApp
{
	internal class Food : InventoryItem
	{
        public Food(double weight = 1, double volume = 0.5) 
             : base(weight, volume)
        {
            
        }
    }
}
