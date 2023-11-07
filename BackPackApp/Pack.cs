using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace BackPackApp
{
	public class Pack
	{
		const double maxWeight = 10;
		const double maxVolume = 10;
		const double maxItems = 20;

		static List<InventoryItem> backpackList = new();

		double volumeSum;
		double weightSum;
		double listCount;

		public bool Add(InventoryItem item) 
		{
			Console.Clear();

            if (volumeSum + item.GetVolume() > maxVolume || weightSum + item.GetWeight() > maxWeight || listCount >= maxItems)
			{
				Console.WriteLine("Backpack is full");
				Console.Read();
				return false;
            }
			else
			{
				backpackList.Add(item);
				volumeSum += item.GetVolume();
				weightSum += item.GetWeight();
				listCount++;
				Console.WriteLine("VolumeSum: " + volumeSum);
				Console.WriteLine("WeightSum: " + weightSum);
				Console.WriteLine("listcount: " + listCount);
				Console.WriteLine($"{nameof(item)} added");
				Console.Read();
				return true;
			}
		}

	}
}
