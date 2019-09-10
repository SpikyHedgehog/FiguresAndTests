using System;
using System.Collections.Generic;
using System.Text;

namespace Figures.Samples
{
	public class Triangle : Figure
	{
		private  double _a = 0, _b = 0, _c = 0;
		private Dot _A, _B, _C;

		public Triangle(Dot A, Dot B, Dot C)
		{
			this.A = (Dot)A.Clone();
			this.B = (Dot)B.Clone();
			this.C = (Dot)C.Clone();
		}

		//Дублирования кода можно избежать, например если написать процедуру апдейта, но вот так мне кажется более наглядным, потому решил оставить такой вариант.
		public Dot A
		{
			get { return _A; }
			set
			{
				_A = (Dot)value.Clone();
				_b = Section.GetLength(A, C);
				_c = Section.GetLength(A, B);
				updateArea();
			}
		}
		public Dot B
		{
			get { return _B; }
			set
			{
				_B = (Dot)value.Clone();
				_a = Section.GetLength(B, C);
				_c = Section.GetLength(A, B);
				updateArea();
			}
		}
		public Dot C
		{
			get { return _C; }
			set
			{
				_C = (Dot)value.Clone();
				_b = Section.GetLength(A, C);
				_a = Section.GetLength(C, B);
				updateArea();
			}
		}
		public double a { get { return _a; } }
		public double b { get { return _b; } }
		public double c { get { return _c; } }

		public bool IsCorrect()
		{
			return isCorrect(a, b, c);
		}

		private static bool isCorrect(double x, double y, double z)
		{
			return y + z - x > 0
				&& x + z - y > 0
				&& x + y - z > 0;
		}

		private bool checkPifagor(double k1, double k2, double g, double eps)
		{
			return Math.Abs(k1 * k1 + k2 * k2 - g * g) <= eps;
		}

		public bool IsRight(double eps = 0.00001)
		{
			return checkPifagor(a, b, c, eps)
				|| checkPifagor(a, c, b, eps)
				|| checkPifagor(b, c, a, eps);
		}

		public static double GetAreaBySides(double x, double y, double z)
		{
			if (x <= 0 || y <= 0 || z <= 0 || !isCorrect(x, y, z))
			{
				return 0;
			}
			else
			{
				double p = (x + y + z) / 2;
				return Math.Sqrt(p * (p - x) * (p - y) * (p - z));
			}
		}
		protected override void updateArea()
		{
			_area = GetAreaBySides(a, b, c);
		}
	}
}
