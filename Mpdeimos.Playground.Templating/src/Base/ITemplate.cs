using System;

namespace Mpdeimos.Playground.Templating.Base
{
	public interface ITemplate
	{
		void Bind(string key, object value);

		string Render();
	}
}

