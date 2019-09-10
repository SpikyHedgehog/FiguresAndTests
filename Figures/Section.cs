using System;
using System.Collections.Generic;
using System.Text;

namespace Figures
{
	public class Section
	{
		private double? length;
		private void updateLength()
		{
			length = Section.GetLength(First, Second);
		}

		private Dot _first, _second;
		public Dot First
		{
			get { return _first; }
			set
			{
				_first = (Dot)value.Clone();
				updateLength();
			}
		}
		public Dot Second
		{
			get { return _second; }
			set
			{
				_second = (Dot)value.Clone();
				updateLength();
			}
		}
		public double Length
		{
			get
			{
				if (!length.HasValue)
				{
					updateLength();
				}
				return length.Value;
			}
		}

		public static double GetLength(Dot A, Dot B)
		{
			if (A == null || B == null)
			{
				return 0;
			}
			else
			{
				return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
			}
		}

		public Section(Dot A, Dot B)
		{
			this.First = (Dot)A.Clone();
			this.Second = (Dot)B.Clone();
		}
	}
}
