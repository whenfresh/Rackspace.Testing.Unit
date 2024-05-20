﻿namespace Testing.Unit.Facts.Tests
{
    using Testing.Unit.Facts.Types;
    using WhenFresh.Rackspace;
    using WhenFresh.Rackspace.Tests;
    using Xunit;

    public sealed class XmlAttributeTestFacts
    {
        [Fact]
        public void ctor()
        {
            Assert.NotNull(new XmlAttributeTest(typeof(XmlDecorationClass1).GetProperty("Attribute")));
        }

        [Fact]
        public void is_AttributePropertyTest()
        {
            Assert.IsAssignableFrom<MemberTestBase>(new XmlAttributeTest(typeof(XmlDecorationClass1).GetProperty("Attribute")));
        }

        [Fact]
        public void op_Check_whenNameWrong()
        {
            var obj = new XmlAttributeTest(typeof(XmlDecorationClass1).GetProperty("Attribute"))
                          {
                              AttributeName = "xxx"
                          };

            Assert.Throws<UnitTestException>(() => obj.Check());
        }

        [Fact]
        public void op_Check_whenNamespaceWrong()
        {
            var obj = new XmlAttributeTest(typeof(XmlDecorationClass1).GetProperty("Attribute"))
                          {
                              AttributeName = "attribute",
                              Namespace = "xxx"
                          };

            Assert.Throws<UnitTestException>(() => obj.Check());
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            var obj = new XmlAttributeTest(typeof(XmlDecorationClass1).GetProperty("NamespaceAttribute"))
                          {
                              AttributeName = "attribute",
                              Namespace = "urn:example.org"
                          };

            Assert.True(obj.Check());
        }

        [Fact]
        public void op_Check_whenXmlAttributeMissing()
        {
            var obj = new XmlAttributeTest(typeof(PropertiedClass1).GetProperty("AutoBoolean"));

            Assert.Throws<UnitTestException>(() => obj.Check());
        }

        [Fact]
        public void prop_AttributeName()
        {
            const string expected = "example";

            var obj = new XmlAttributeTest(typeof(XmlDecorationClass1).GetProperty("Attribute"))
                          {
                              AttributeName = expected
                          };

            var actual = obj.AttributeName;

            Assert.Same(expected, actual);
        }

        [Fact]
        public void prop_Namespace()
        {
            const string expected = "example";

            var obj = new XmlAttributeTest(typeof(XmlDecorationClass1).GetProperty("Attribute"))
                          {
                              Namespace = expected
                          };

            var actual = obj.Namespace;

            Assert.Same(expected, actual);
        }
    }
}