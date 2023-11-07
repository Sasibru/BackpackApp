using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPackApp
{
	public class Arrow : InventoryItem
	{
        public Arrow(double weight = 0.1, double volume = 0.05) 
            : base (weight, volume)
        {
            
        }
    }
}
