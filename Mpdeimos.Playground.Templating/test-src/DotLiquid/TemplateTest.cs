using NUnit.Framework;
using System;
using Mpdeimos.Playground.Templating.Base;

namespace Mpdeimos.Playground.Templating.DotLiquid
{
	[TestFixture()]
	public class TemplateTest : TemplateTestBase
	{
		protected override ITemplateManager CreateTemplateManager()
		{
			return new TemplateManager();
		}
	}
}

