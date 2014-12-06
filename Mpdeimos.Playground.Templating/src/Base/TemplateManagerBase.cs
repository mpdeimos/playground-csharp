using System;
using System.IO;

namespace Mpdeimos.Playground.Templating.Base
{
	public abstract class TemplateManagerBase : ITemplateManager
	{
		public ITemplate Get(string name)
		{
			string source = this.ReadResource(GetTemplateFilename(name));
			return Create(source);
		}

		private string ReadResource(string name)
		{
			var assembly = this.GetType().Assembly;
			var @namespace = this.GetType().Namespace;
			using (var stream = assembly.GetManifestResourceStream(@namespace + ".Resource." + name))
			{
				using (var reader = new StreamReader(stream))
				{
					return reader.ReadToEnd();
				}
			}
		}

		protected abstract ITemplate Create(string source);

		protected abstract string GetTemplateFilename(string name);
	}
}

