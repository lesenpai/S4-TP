using System;
using System.Collections.Generic;

namespace S4_TP.Lab4.Data
{
	[Serializable]
	public class Lab4Data
	{
		public List<Pair> Points = new List<Pair>();

		public void Add(double x, double f)
		{
			Points.Add(new Pair(x, f));
		}
	}
}