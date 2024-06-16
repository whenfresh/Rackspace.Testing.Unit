namespace WhenFresh.Rackspace.Testing.Unit.Facts.Tests
{
    using WhenFresh.Rackspace.Testing.Unit;
    using WhenFresh.Rackspace.Testing.Unit.Facts.Types;
    using WhenFresh.Rackspace.Testing.Unit.Fluent;
    using WhenFresh.Rackspace.Testing.Unit.Tests;
    using Xunit;

    public sealed class AbstractBaseClassTestOfTFacts
    {
        [Fact]
        public void ctor()
        {
            Assert.NotNull(new AbstractBaseClassTest<object>());
        }

        [Fact]
        public void is_ITestExpectation()
        {
            Assert.IsAssignableFrom<ITestExpectation>(new AbstractBaseClassTest<int>());
        }

        [Fact]
        public void op_Check_whenFalse()
        {
            Assert.Throws<UnitTestException>(() => new AbstractBaseClassTest<int>().Check());
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            Assert.True(new AbstractBaseClassTest<AbstractBaseClass1>().Check());
        }
    }
}