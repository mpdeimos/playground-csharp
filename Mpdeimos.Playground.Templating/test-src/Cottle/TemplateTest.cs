using NUnit.Framework;
using System;
using Mpdeimos.Playground.Templating.Base;

namespace Mpdeimos.Playground.Templating.Cottle
{
	[TestFixture()]
	public class TemplateTest : TemplateTestBase
	{
		protected override ITemplateManager CreateTemplateManager()
		{
			return new TemplateManager();
		}

		[Test]
		[Ignore("Not supported yet. Must write custom function for this to work.")]
		public override void TestIncludeTemplate()
		{
			base.TestIncludeTemplate();
		}
	}
}

