using System;
using System.IO;
using System.Reflection;

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
			using (var stream = GetBaseAssembly().GetManifestResourceStream(GetBaseNamespace() + "." + name))
			{
				using (var reader = new StreamReader(stream))
				{
					return reader.ReadToEnd();
				}
			}
		}

		protected string GetBaseNamespace()
		{
			return this.GetType().Namespace + ".Resource";
		}

		protected Assembly GetBaseAssembly()
		{
			return this.GetType().Assembly;
		}

		protected abstract ITemplate Create(string source);

		protected abstract string GetTemplateFilename(string name);
	}
}

