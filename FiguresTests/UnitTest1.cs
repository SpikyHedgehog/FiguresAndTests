using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FiguresTests
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void SimpleTest()
		{
			Assert.IsTrue(true);
			Assert.IsFalse(false);
			Assert.AreEqual(5, 5);
		}
	}
}
