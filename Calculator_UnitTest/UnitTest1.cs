using System;
using Microsoft.QualityTools.Testing.Fakes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator_UnitTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			using (ShimsContext.Create())
			{
				System.Fakes.ShimDateTime.NowGet = () => {
					return new DateTime(2020, 12, 12);
				};

				Calculator.Calculator c = new Calculator.Calculator();
				var result = c.Div(1, 2);
				Assert.AreEqual(0, result);

			}
				
		}


		[TestMethod]
		public void TestMethod2()
		{
			using (ShimsContext.Create())
			{
				System.Fakes.ShimDateTime.NowGet = () => {
					return new DateTime(2020, 12, 12);
				};

				Calculator.Calculator c = new Calculator.Calculator();
				var result = c.GetDateTime();
				Assert.AreNotEqual(null, result);

			}

		}
	}
}
