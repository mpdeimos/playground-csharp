using System;
using Cottle.Documents;
using Cottle;
using Cottle.Values;
using System.Reflection;
using Cottle.Stores;

namespace Mpdeimos.Playground.Templating.Cottle
{
	public class Template : TemplateBase
	{
		private IDocument template;
		private IStore store;

		public Template(string source)
			: base(source)
		{
			template = new SimpleDocument(source);
			store = new BuiltinStore();
		}

		public override void Bind(string key, object value)
		{
			store[key] = new ReflectionValue(value);
		}

		public override string Render()
		{
			return template.Render(store);
		}
	}
}

