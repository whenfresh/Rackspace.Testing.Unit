﻿namespace WhenFresh.Utilities.Testing.Unit.Facts.Tests
{
    using WhenFresh.Utilities.Testing.Unit;
    using WhenFresh.Utilities.Testing.Unit.Facts.Types;
    using WhenFresh.Utilities.Testing.Unit.Tests;
    using Xunit;

    public sealed class XmlTextTestFacts
    {
        [Fact]
        public void ctor()
        {
            Assert.NotNull(new XmlTextTest(typeof(XmlDecorationClass1).GetProperty("Text")));
        }

        [Fact]
        public void is_AttributePropertyTest()
        {
            Assert.IsAssignableFrom<MemberTestBase>(new XmlTextTest(typeof(XmlDecorationClass1).GetProperty("Text")));
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            var obj = new XmlTextTest(typeof(XmlDecorationClass1).GetProperty("Text"));

            Assert.True(obj.Check());
        }

        [Fact]
        public void op_Check_whenXmlIgnoreMissing()
        {
            var obj = new XmlTextTest(typeof(PropertiedClass1).GetProperty("AutoBoolean"));

            Assert.Throws<UnitTestException>(() => obj.Check());
        }
    }
}