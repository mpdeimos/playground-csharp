using System;
using Mpdeimos.Playground.Templating.Base;
using DotLiquid.FileSystems;

namespace Mpdeimos.Playground.Templating.DotLiquid
{
	public class TemplateManager : TemplateManagerBase
	{
		public TemplateManager()
		{
			global::DotLiquid.Template.FileSystem = new EmbeddedFileSystem(this.GetBaseAssembly(), this.GetBaseNamespace());
		}

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

