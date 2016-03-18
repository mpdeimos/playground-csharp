using System;

namespace Mpdeimos.Playground.ObjectProxy
{
	public interface IUnrustyObject
	{
		int RustyProperty { get; }

		IUndustyObject DustyObject { get; }
	}
}

