﻿namespace WhenFresh.Utilities.Testing.Unit.Facts.Tests
{
    using WhenFresh.Utilities.Testing.Unit;
    using WhenFresh.Utilities.Testing.Unit.Facts.Types;
    using WhenFresh.Utilities.Testing.Unit.Fluent;
    using WhenFresh.Utilities.Testing.Unit.Tests;
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