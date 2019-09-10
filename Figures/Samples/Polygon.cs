using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Figures.Samples
{
	public class Polygon : Figure
	{
		public List<Dot> Dots;

		public Polygon(List<Dot> dots)
		{
			this.Dots = dots;
			updateArea();
		}

		private double getOrientedTrapeziumArea(Dot first, Dot second)
		{
			return (first.Y + second.Y) * (second.X - first.X) / 2;
		}
		public void UpdateArea()
		{
			updateArea();
		}
		protected override void updateArea()
		{
			if (Dots.Count <= 2)
			{
				_area = 0;
			}
			else
			{
				double currentarea = 0;

				for (int i = 1; i < Dots.Count; ++i)
				{
					currentarea += getOrientedTrapeziumArea(Dots[i - 1], Dots[i]);
				}

				currentarea += getOrientedTrapeziumArea(Dots[Dots.Count - 1], Dots[0]);
				_area = Math.Abs(currentarea);
			}
		}
	}
}
