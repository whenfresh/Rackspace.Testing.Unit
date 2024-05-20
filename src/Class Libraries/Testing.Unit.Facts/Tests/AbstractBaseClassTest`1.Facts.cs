namespace Testing.Unit.Facts.Tests
{
    using Testing.Unit.Facts.Types;
    using WhenFresh.Rackspace;
    using WhenFresh.Rackspace.Fluent;
    using WhenFresh.Rackspace.Tests;
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