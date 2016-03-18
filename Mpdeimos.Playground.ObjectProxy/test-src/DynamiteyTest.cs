using NUnit.Framework;

namespace Mpdeimos.Playground.ObjectProxy
{
	[TestFixture]
	public class DynamiteyTest
	{
		[Test]
		public void TestMakeDusty()
		{
			var rust = RustProvider.GetRust();

			ImpromptuInterface.Impromptu
			Assert.AreEqual("Dusty foo", RustProvider.GetRust().DustyObject.MakeDusty("foo"));
		}
	}
}

