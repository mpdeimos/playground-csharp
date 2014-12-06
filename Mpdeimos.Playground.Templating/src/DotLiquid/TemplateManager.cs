using System;
using Mpdeimos.Playground.Templating.Base;

namespace Mpdeimos.Playground.Templating.DotLiquid
{
	public class TemplateManager : TemplateManagerBase
	{
		protected override ITemplate Create(string source)
		{
			return new Template(source);
		}

		protected override string GetTemplateFilename(string name)
		{
			return name + ".liquid";
		}
	}
}

