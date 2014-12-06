using System;
using Mpdeimos.Playground.Templating.Base;

namespace Mpdeimos.Playground.Templating
{
	public abstract class TemplateBase : ITemplate
	{
		public string Source { get; private set; }

		public TemplateBase(string source)
		{
			this.Source = source;
		}

		public abstract void Bind(string key, object value);

		public abstract string Render();
	}
}

