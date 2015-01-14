using NUnit.Framework;
using System;
using Mpdeimos.Playground.Templating.Base;

namespace Mpdeimos.Playground.Templating.StringTemplate
{
	[TestFixture()]
	public class TemplateTest : TemplateTestBase
	{
		protected override ITemplateManager CreateTemplateManager()
		{
			return new TemplateManager();
		}

		[Test]
		[Ignore("Not possible.")]
		public override void TestIncludeTemplate()
		{
			base.TestIncludeTemplate();
		}
	}
}

