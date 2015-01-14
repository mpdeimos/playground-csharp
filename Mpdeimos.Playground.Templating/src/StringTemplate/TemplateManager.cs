using System;
using Mpdeimos.Playground.Templating.Base;
using ST = Antlr4.StringTemplate;

namespace Mpdeimos.Playground.Templating.StringTemplate
{
	public class TemplateManager : TemplateManagerBase
	{
		protected override ITemplate Create(string source)
		{
			return new Template(source);
		}

		protected override string GetTemplateFilename(string name)
		{
			return name + ".st";
		}
	}
}

