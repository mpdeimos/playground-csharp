using System;

namespace Mpdeimos.Playground.Templating.Base
{
	public interface ITemplateManager
	{
		ITemplate Get(string name);
	}
}

