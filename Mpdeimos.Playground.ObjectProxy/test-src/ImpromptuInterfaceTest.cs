using System;
using NUnit.Framework;
using ImpromptuInterface;

namespace Mpdeimos.Playground.ObjectProxy
{
	[TestFixture]
	public class ImpromptuInterfaceTest
	{
		[Test]
		public void TestMakeDusty()
		{
			var rust = RustProvider.GetRust();
			IUnrustyObject unrusty = rust.ActLike<IUnrustyObject>();

			Assert.AreEqual(1, unrusty.RustyProperty);
			Assert.AreEqual("Dusty foo", unrusty.DustyObject.MakeDusty("foo"));
		}
	}
}

