using System;
using NUnit.Framework;

namespace Mpdeimos.Playground.ObjectProxy
{
	[TestFixture]
	public class DirectCallTest
	{
		[Test]
		public void TestMakeDusty()
		{
			var rust = RustProvider.GetRust();
			Assert.AreEqual(1, rust.RustyProperty);
			Assert.AreEqual("Dusty foo", rust.DustyObject.MakeDusty("foo"));
		}
	}
}

