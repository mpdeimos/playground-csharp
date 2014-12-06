using System;
using ST = Antlr4.StringTemplate;

namespace Mpdeimos.Playground.Templating.StringTemplate
{
	public class Template : TemplateBase
	{
		public const char StartTag = '{';
		public const char EndTag = '}';

		private ST.Template template;

		public Template(string source)
			: base(source)
		{
			template = new ST.Template(source, StartTag, EndTag);
		}

		public override void Bind(string key, object value)
		{
			template.Add(key, value);
		}

		public override string Render()
		{
			return template.Render();
		}
	}
}

