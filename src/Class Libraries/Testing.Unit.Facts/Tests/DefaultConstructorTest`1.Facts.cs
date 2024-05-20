﻿namespace Testing.Unit.Facts.Tests
{
    using WhenFresh.Rackspace;
    using WhenFresh.Rackspace.Fluent;
    using WhenFresh.Rackspace.Tests;
    using Xunit;

    public sealed class DefaultConstructorTestOfTFacts
    {
        [Fact]
        public void ctor()
        {
            Assert.NotNull(new DefaultConstructorTest<object>());
        }

        [Fact]
        public void is_ITestExpectation()
        {
            Assert.IsAssignableFrom<ITestExpectation>(new DefaultConstructorTest<int>());
        }

        [Fact]
        public void op_Check_whenFalse()
        {
            Assert.Throws<UnitTestException>(() => new DefaultConstructorTest<int>().Check());
        }

        [Fact]
        public void op_Check_whenTrue()
        {
            Assert.True(new DefaultConstructorTest<object>().Check());
        }
    }
}