﻿namespace Testing.Unit.Facts.Tests
{
    using Testing.Unit.Facts.Types;
    using WhenFresh.Rackspace;
    using WhenFresh.Rackspace.Tests;
    using Xunit;

    public sealed class XmlArrayTestFacts
    {
        [Fact]
        public void ctor()
        {
            Assert.NotNull(new XmlArrayTest(typeof(XmlDecorationClass1).GetProperty("Array1")));
        }

        [Fact]
        public void is_AttributePropertyTest()
        {
            Assert.IsAssignableFrom<MemberTestBase>(new XmlArrayTest(typeof(XmlDecorationClass1).GetProperty("Array1")));
        }

        [Fact]
        public void op_Check_whenItemsWrong()
        {
            var obj = new XmlArrayTest(typeof(XmlDecorationClass1).GetProperty("Array1"))
                          {
                              ArrayElementName = "array1",
                              ArrayItemElementName = "xxx"
                          };

            Assert.Throws<UnitTestException>(() => obj.Check());
        }

        [Fact]
        public void op_Check_whenNameWrong()
        {
            var obj = new XmlArrayTest(typeof(XmlDecorationClass1).GetProperty("Array1"))
                          {
                              ArrayElementName = "xxx"
                          };

            Assert.Throws<UnitTestException>(() => obj.Check());
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            var obj = new XmlArrayTest(typeof(XmlDecorationClass1).GetProperty("Array1"))
                          {
                              ArrayElementName = "array1",
                              ArrayItemElementName = "item1"
                          };

            Assert.True(obj.Check());
        }

        [Fact]
        public void op_Check_whenXmlArrayItemMissing()
        {
            var obj = new XmlArrayTest(typeof(XmlDecorationClass1).GetProperty("Array2"))
                          {
                              ArrayElementName = "array2",
                              ArrayItemElementName = "item2"
                          };

            Assert.Throws<UnitTestException>(() => obj.Check());
        }

        [Fact]
        public void op_Check_whenXmlArrayMissing()
        {
            var obj = new XmlArrayTest(typeof(PropertiedClass1).GetProperty("AutoBoolean"));

            Assert.Throws<UnitTestException>(() => obj.Check());
        }

        [Fact]
        public void prop_ArrayElementName()
        {
            const string expected = "example";

            var obj = new XmlArrayTest(typeof(XmlDecorationClass1).GetProperty("Array1"))
                          {
                              ArrayElementName = expected
                          };

            var actual = obj.ArrayElementName;

            Assert.Same(expected, actual);
        }

        [Fact]
        public void prop_ArrayItemElementName()
        {
            const string expected = "example";

            var obj = new XmlArrayTest(typeof(XmlDecorationClass1).GetProperty("Array1"))
                          {
                              ArrayItemElementName = expected
                          };

            var actual = obj.ArrayItemElementName;

            Assert.Same(expected, actual);
        }
    }
}