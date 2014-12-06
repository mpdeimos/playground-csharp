using System;
using DL = DotLiquid;

namespace Mpdeimos.Playground.Templating.DotLiquid
{
	public class Template : TemplateBase
	{
		private DL.Template template;

		public Template(string source)
			: base(source)
		{
			template = DL.Template.Parse(source);
		}

		public override void Bind(string key, object value)
		{
			template.Assigns.Add(key, value);
		}

		public override string Render()
		{
			return template.Render();
		}
	}
}

