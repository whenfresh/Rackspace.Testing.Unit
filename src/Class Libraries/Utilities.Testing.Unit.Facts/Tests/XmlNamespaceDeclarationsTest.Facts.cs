namespace WhenFresh.Utilities.Testing.Unit.Facts.Tests
{
    using WhenFresh.Utilities.Testing.Unit;
    using WhenFresh.Utilities.Testing.Unit.Facts.Types;
    using WhenFresh.Utilities.Testing.Unit.Tests;
    using Xunit;

    public sealed class XmlNamespaceDeclarationsTestFacts
    {
        [Fact]
        public void ctor()
        {
            Assert.NotNull(new XmlNamespaceDeclarationsTest(typeof(XmlDecorationClass1).GetProperty("Array1")));
        }

        [Fact]
        public void is_AttributePropertyTest()
        {
            Assert.IsAssignableFrom<MemberTestBase>(new XmlNamespaceDeclarationsTest(typeof(XmlDecorationClass1).GetProperty("Array1")));
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            var obj = new XmlNamespaceDeclarationsTest(typeof(XmlDecorationClass1).GetProperty("Array1"));

            Assert.True(obj.Check());
        }

        [Fact]
        public void op_Check_whenXmlIgnoreMissing()
        {
            var obj = new XmlNamespaceDeclarationsTest(typeof(PropertiedClass1).GetProperty("AutoBoolean"));

            Assert.Throws<UnitTestException>(() => obj.Check());
        }
    }
}