using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using Figures.Samples;

namespace FiguresTests
{
	[TestClass]
	public class TriangleTests
	{
		[TestMethod]
		public void AreaTest()
		{
			var myTriangle = new Triangle(new Dot(0, 0), new Dot(0, 6), new Dot(10, 0));
			Assert.AreEqual(30, myTriangle.Area);
		}

		[TestMethod]
		public void RightTest()
		{
			var myTriangle = new Triangle(new Dot(0, 0), new Dot(0, 6), new Dot(10, 0));
			Assert.IsTrue(myTriangle.IsRight());
			myTriangle.A = new Dot(1, 1);
			Assert.IsFalse(myTriangle.IsRight());
		}

		[TestMethod]
		public void GeronTest()
		{
			Assert.AreEqual(6, Triangle.GetAreaBySides(3, 4, 5));
		}

		[TestMethod]
		public void ChangedDotTest()
		{
			var myTriangle = new Triangle(new Dot(0, 0), new Dot(0, 6), new Dot(10, 0));
			Assert.AreEqual(30, myTriangle.Area);
			myTriangle.A = new Dot(-1, 0);
			Assert.AreEqual(33, myTriangle.Area, 0.00000001);
			var myDot = new Dot(-1, 0);
			myTriangle.A = myDot;
			Assert.AreEqual(33, myTriangle.Area, 0.00000001);
			myDot.X = 0;
			Assert.AreEqual(-1, myTriangle.A.X);
		}
	}
}
