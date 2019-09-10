using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using Figures.Samples;

namespace FiguresTests
{
	[TestClass]
	public class PolygonTests
	{
		[TestMethod]
		public void PolygonAreaTest()
		{
			var myDots = new List<Dot>();
			var myPolygon = new Polygon(myDots);
			myDots.Add(new Dot(-3, -2));
			myDots.Add(new Dot(-6, -2));

			myPolygon.UpdateArea();
			Assert.AreEqual(0, myPolygon.Area);

			myDots.Add(new Dot(-6, 2));

			myPolygon.UpdateArea();
			Assert.AreEqual(6, myPolygon.Area);

			myDots.Add(new Dot(-3, 2));

			myPolygon.UpdateArea();
			Assert.AreEqual(12, myPolygon.Area);
		}
	}
}
