using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPackApp
{
	public class Rope : InventoryItem
	{
        public Rope(double weight = 1, double volume = 1.5) 
             : base(weight, volume)
        {
            
        }
    }
}
