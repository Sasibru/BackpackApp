using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackPackApp
{
	public class InventoryItem
	{
        public double Weight { get; private set; }
        public double Volume { get; private set; }

        public InventoryItem( double weight, double volume)
        {
            Weight = weight;
            Volume = volume;
        }

        public double GetWeight() 
        { 
            return Weight; 
        }

        public double GetVolume()
        {
            return Volume;
        }
    }
}
