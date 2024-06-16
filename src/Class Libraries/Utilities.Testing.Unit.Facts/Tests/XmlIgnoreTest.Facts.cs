namespace WhenFresh.Rackspace.Testing.Unit.Facts.Tests
{
    using WhenFresh.Rackspace.Testing.Unit;
    using WhenFresh.Rackspace.Testing.Unit.Facts.Types;
    using WhenFresh.Rackspace.Testing.Unit.Tests;
    using Xunit;

    public sealed class XmlIgnoreTestFacts
    {
        [Fact]
        public void ctor()
        {
            Assert.NotNull(new XmlIgnoreTest(typeof(XmlDecorationClass1).GetProperty("Ignore")));
        }

        [Fact]
        public void is_AttributePropertyTest()
        {
            Assert.IsAssignableFrom<MemberTestBase>(new XmlIgnoreTest(typeof(XmlDecorationClass1).GetProperty("Ignore")));
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            var obj = new XmlIgnoreTest(typeof(XmlDecorationClass1).GetProperty("Ignore"));

            Assert.True(obj.Check());
        }

        [Fact]
        public void op_Check_whenXmlIgnoreMissing()
        {
            var obj = new XmlIgnoreTest(typeof(PropertiedClass1).GetProperty("AutoBoolean"));

            Assert.Throws<UnitTestException>(() => obj.Check());
        }
    }
}