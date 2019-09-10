using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
using Figures.Samples;

namespace FiguresTests
{
	[TestClass]
	public class CircleTests
	{
		[TestMethod]
		public void CircleAreaTest()
		{
			var testCircle = new Circle(new Dot(0, 0), 5);
			Assert.AreEqual(78.5398, testCircle.Area, 0.0001);
		}
		[TestMethod]
		public void CircleAreaTestStrangeRadius()
		{
			var testCircle = new Circle(new Dot(0, 0), -3);
			Assert.AreEqual(28.2743, testCircle.Area, 0.0001);
		}

		[TestMethod]
		public void CircleAreaByStaticMethod()
		{
			Assert.AreEqual(12.5664, Circle.GetArea(2), 0.0001);
		}

		[TestMethod]
		public void CircleAreaChangeCenter()
		{
			var testCircle = new Circle(new Dot(0, 0), 2);
			Assert.AreEqual(12.5664, testCircle.Area, 0.0001);
			testCircle.Center = new Dot(-25, 47);
			Assert.AreEqual(12.5664, testCircle.Area, 0.0001);
		}
		[TestMethod]
		public void CircleAreaChangeRadius()
		{
			var testCircle = new Circle(new Dot(0, 0), 1);
			Assert.AreEqual(3.1416, testCircle.Area, 0.0001);
			testCircle.Radius = 5;
			Assert.AreEqual(78.5398, testCircle.Area, 0.0001);
		}
	}
}
