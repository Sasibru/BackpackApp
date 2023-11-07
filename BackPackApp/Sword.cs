using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPackApp
{
	internal class Sword : InventoryItem
	{
        public Sword(double weight = 5, double volume = 3) 
              : base(weight, volume)
        {
            
        }
    }
}
