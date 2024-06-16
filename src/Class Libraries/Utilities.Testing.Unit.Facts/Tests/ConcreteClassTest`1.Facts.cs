namespace WhenFresh.Rackspace.Testing.Unit.Facts.Tests
{
    using WhenFresh.Rackspace.Testing.Unit;
    using WhenFresh.Rackspace.Testing.Unit.Facts.Types;
    using WhenFresh.Rackspace.Testing.Unit.Fluent;
    using WhenFresh.Rackspace.Testing.Unit.Tests;
    using Xunit;

    public sealed class ConcreteClassTestOfTFacts
    {
        [Fact]
        public void ctor()
        {
            Assert.NotNull(new ConcreteClassTest<object>());
        }

        [Fact]
        public void is_ITestExpectation()
        {
            Assert.IsAssignableFrom<ITestExpectation>(new ConcreteClassTest<int>());
        }

        [Fact]
        public void op_Check_whenFalse()
        {
            Assert.Throws<UnitTestException>(() => new ConcreteClassTest<AbstractBaseClass1>().Check());
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            Assert.True(new ConcreteClassTest<string>().Check());
        }
    }
}