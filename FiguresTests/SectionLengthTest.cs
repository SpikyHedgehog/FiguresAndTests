using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Figures;
namespace FiguresTests
{
	[TestClass]
	public class SectionTest
	{
		[TestMethod]
		public void SectionLengthTest()
		{
			Dot A = new Dot(-3, -2);
			Dot B = new Dot(-6, 2);
			Section sect = new Section(A, B);
			Assert.AreEqual(sect.Length, 5);
		}
		[TestMethod]
		public void SectionChangedLengthTest()
		{
			Dot A = new Dot();
			Dot B = new Dot(7, 0);
			Section sect = new Section(A, B);
			Assert.AreEqual(sect.Length, 7);
			A.X = -3;
			sect.First = A;
			Assert.AreEqual(sect.Length, 10);
		}
	}
}
