using System.Linq;

namespace Parcels.Models
{
	public class Parcel
	{
		private string Description { get; set; }
		private int[] Dimensions { get; set; }
		private float Weight { get; set; }

		public Parcel(string description, int x, int y, int z, float weight)
		{
			Description = description;
			Dimensions = new int[]{x,y,z};
			Weight = weight;
		}

		public long Volume()
		{
			return Dimensions[0]*Dimensions[1]*Dimensions[2];
		}

		public float CostToShip()
		{
			float densityCost = 1.00;
			long volume = Volume();
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
			return (Weight/volume)*densityCost;
		}
	}
}