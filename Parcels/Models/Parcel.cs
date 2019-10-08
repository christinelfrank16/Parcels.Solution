using System.Linq;

namespace Parcels.Models
{
	public class Parcel
	{
		private int[] Dimensions { get; set; }
		private long Volume { get; set; }
		private float Weight { get; set; }

		public Parcel(int x, int y, int z, float weight)
		{
			Dimensions = new int[]{x,y,z};
			Volume = x*y*z;
			Weight = weight;
		}

		public float CostToShip()
		{
			float densityCost = 1.00;
			if(Dimensions.Max() > 30 && Weight > 10)
			{
				densityCost = 1.35;
			}
			else if(Dimensions.Max() > 48 || Weight > 25)
			{
				densityCost = 2.55;
			}
			else if(Dimensions.Max() > 60 || Weight > 35)
			{
				densityCost = 4.00;
			}
			return (Weight/Volume)*densityCost;
		}
	}
}