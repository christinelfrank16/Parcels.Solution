using System.Linq;
using System.Collections.Generic;

using System;
namespace Parcels.Models
{
	public class Parcel
	{
		public string Description { get; set; }
		public int[] Dimensions { get; set; }
		public double Weight { get; set; }
		public static List<Parcel> _parcelList = new List<Parcel> {};

		public Parcel(string description, int x, int y, int z, double weight)
		{
			Description = description;
			Dimensions = new int[]{x,y,z};
			Weight = weight;
			_parcelList.Add(this);
		}

		public long Volume()
		{
			return Dimensions[0]*Dimensions[1]*Dimensions[2];
		}

		public double CostToShip()
		{
			double densityCost = 10.00;
			long volume = Volume();
			if(Dimensions.Max() > 60 || Weight > 35)
			{
				densityCost = 40.00;
			}
			else if(Dimensions.Max() > 48 || Weight > 25)
			{
				densityCost = 20.55;
			}
			else if(Dimensions.Max() > 30 && Weight > 10)
			{
				densityCost = 10.35;
			}
			return Math.Round((volume/Weight)*densityCost,2);
		}

		public static List<Parcel> GetAll()
		{
			return _parcelList;
		}

	}
}