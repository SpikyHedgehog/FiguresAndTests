using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
	public class Dot : ICloneable
	{
		public double X { get; set; }
		public double Y { get; set; }

		public Dot(double x = 0, double y = 0)
		{
			this.X = x;
			this.Y = y;
		}

		public object Clone()
		{
			return new Dot(this.X, this.Y);
		}
	}
}
