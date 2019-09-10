using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Samples
{
	public class Circle : Figure
	{
		private double _radius;
		private Dot _center;
		public Dot Center
		{
			get { return _center; }
			set
			{
				this._center = (Dot)value.Clone();
			}
		}
		public double Radius
		{
			get	{ return _radius; }
			set
			{
				_radius = value;
				updateArea();
			}
		}
		
		protected override void updateArea()
		{
			_area = GetArea(Radius);
		}

		public static double GetArea(double r)
		{
			return Math.PI * Math.Pow(r, 2);
		}
		public Circle(Dot Center, double R)
		{
			this.Center = Center;
			this.Radius = R;
		}
	}
}
