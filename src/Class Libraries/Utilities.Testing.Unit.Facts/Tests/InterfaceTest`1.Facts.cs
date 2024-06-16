﻿namespace WhenFresh.Utilities.Testing.Unit.Facts.Tests
{
    using WhenFresh.Utilities.Testing.Unit;
    using WhenFresh.Utilities.Testing.Unit.Fluent;
    using WhenFresh.Utilities.Testing.Unit.Tests;
    using Xunit;

    public sealed class InterfaceTestOfTFacts
    {
        [Fact]
        public void ctor_Type()
        {
            Assert.NotNull(new InterfaceTest<ITestType>());
        }

        [Fact]
        public void is_ITestExpectation()
        {
            Assert.IsAssignableFrom<ITestExpectation>(new InterfaceTest<ITestType>());
        }

        [Fact]
        public void op_Check_whenFalse()
        {
            Assert.Throws<UnitTestException>(() => new InterfaceTest<object>().Check());
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            Assert.True(new InterfaceTest<ITestType>().Check());
        }
    }
}