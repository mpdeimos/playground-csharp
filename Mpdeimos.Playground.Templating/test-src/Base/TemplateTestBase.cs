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
		public void Init()
		{
			this.templateManager = CreateTemplateManager();
		}

		[Test]
		public void TestPlainTemplate()
		{
			ITemplate template = this.templateManager.Get("plain");
			Assert.AreEqual("Hello World!", template.Render());
		}

		[Test]
		public void TestSimpleTemplate()
		{
			ITemplate template = this.templateManager.Get("simple");
			template.Bind("hello", "Hello");
			template.Bind("world", "World");
			Assert.AreEqual("Hello World!", template.Render());
		}

		[Test]
		public void TestPropertiesTemplate()
		{
			ITemplate template = this.templateManager.Get("properties");
			template.Bind("obj", new {
				Hello = "Hello",
				World = "World"
			});
			Assert.AreEqual("Hello World!", template.Render());
		}

		[Test]
		public void TestSubPropertiesTemplate()
		{
			ITemplate template = this.templateManager.Get("subproperties");
			template.Bind("obj", new {
				SubObj = new
				{
					Hello = "Hello",
					World = "World"
				}
			});
			Assert.AreEqual("Hello World!", template.Render());
		}

		[Test]
		public void TestConditionTemplate()
		{
			ITemplate template = this.templateManager.Get("condition");
			template.Bind("universe", true);
			Assert.AreEqual("Hello Universe!", template.Render());

			template = this.templateManager.Get("condition");
			template.Bind("universe", false);
			Assert.AreEqual("Hello World!", template.Render());
		}

		[Test]
		public void TestLoopTemplate()
		{
			ITemplate template = this.templateManager.Get("loop");
			template.Bind("list", new List<string>{ "Munich", "World", "Universe" });
			Assert.AreEqual("Hello Munich!\nHello World!\nHello Universe!\n", template.Render());

			template = this.templateManager.Get("loop");
			template.Bind("list", new List<string>{ "Munich" });
			Assert.AreEqual("Hello Munich!\n", template.Render());
		}

		[Test]
		public void TestConcatenateTemplate()
		{
			ITemplate template = this.templateManager.Get("concatenate");
			template.Bind("list", new List<string>{ "Munich", "World", "Universe" });
			Assert.AreEqual("Hello Munich, World, Universe!", template.Render());

			template = this.templateManager.Get("concatenate");
			template.Bind("list", new List<string>{ "Munich" });
			Assert.AreEqual("Hello Munich!", template.Render());
		}

		protected abstract ITemplateManager CreateTemplateManager();
	}
}

