using System;

namespace Figures
{
	public abstract class Figure
	{
		protected double? _area;
		protected abstract void updateArea();
		public double Area
		{
			get
			{
				if (!_area.HasValue)
				{
					updateArea();
				}
				return _area.Value;
			}
		}
	}
}
