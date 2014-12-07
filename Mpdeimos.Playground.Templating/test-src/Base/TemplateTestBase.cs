using Mpdeimos.Playground.Templating.Base;
using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Mpdeimos.Playground.Templating.Base
{
	[TestFixture]
	public abstract class TemplateTestBase
	{
		private ITemplateManager templateManager;

		[SetUp]
		public virtual void Init()
		{
			this.templateManager = CreateTemplateManager();
		}

		[Test]
		public virtual void TestPlainTemplate()
		{
			ITemplate template = this.templateManager.Get("plain");
			AreEqualLines("Hello World!", template.Render());
		}

		[Test]
		public virtual void TestSimpleTemplate()
		{
			ITemplate template = this.templateManager.Get("simple");
			template.Bind("hello", "Hello");
			template.Bind("world", "World");
			AreEqualLines("Hello World!", template.Render());
		}

		[Test]
		public virtual void TestPropertiesTemplate()
		{
			ITemplate template = this.templateManager.Get("properties");
			template.Bind("obj", new {
				Hello = "Hello",
				World = "World"
			});
			AreEqualLines("Hello World!", template.Render());
		}

		[Test]
		public virtual void TestSubPropertiesTemplate()
		{
			ITemplate template = this.templateManager.Get("subproperties");
			template.Bind("obj", new {
				SubObj = new
				{
					Hello = "Hello",
					World = "World"
				}
			});
			AreEqualLines("Hello World!", template.Render());
		}

		[Test]
		public virtual void TestConditionTemplate()
		{
			ITemplate template = this.templateManager.Get("condition");
			template.Bind("universe", true);
			AreEqualLines("Hello Universe!", template.Render());

			template = this.templateManager.Get("condition");
			template.Bind("universe", false);
			AreEqualLines("Hello World!", template.Render());
		}

		[Test]
		public virtual void TestLoopTemplate()
		{
			ITemplate template = this.templateManager.Get("loop");
			template.Bind("list", new List<string>{ "Munich", "World", "Universe" });
			AreEqualLines("Hello Munich!\nHello World!\nHello Universe!\n", template.Render());

			template = this.templateManager.Get("loop");
			template.Bind("list", new List<string>{ "Munich" });
			AreEqualLines("Hello Munich!\n", template.Render());
		}

		[Test]
		public virtual void TestConcatenateTemplate()
		{
			ITemplate template = this.templateManager.Get("concatenate");
			template.Bind("list", new List<string>{ "Munich", "World", "Universe" });
			AreEqualLines("Hello Munich, World, Universe!", template.Render());

			template = this.templateManager.Get("concatenate");
			template.Bind("list", new List<string>{ "Munich" });
			AreEqualLines("Hello Munich!", template.Render());
		}

		private static void AreEqualLines(string expected, string actual)
		{
			expected = expected.Replace("\r\n", "\n");
			actual = actual.Replace("\r\n", "\n");
			Assert.AreEqual(expected, actual);
		}

		protected abstract ITemplateManager CreateTemplateManager();
	}
}

