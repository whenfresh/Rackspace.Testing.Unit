﻿namespace Testing.Unit.Facts
{
    using System;
    using WhenFresh.Rackspace;
    using Xunit;

    public sealed class UnitTestExceptionFacts
    {
        [Fact]
        public void a_definition()
        {
            Assert.True(new TypeExpectations<UnitTestException>()
                            .DerivesFrom<Exception>()
                            .IsConcreteClass()
                            .IsSealed()
                            .HasDefaultConstructor()
                            .Serializable()
                            .Result);
        }

        [Fact]
        public void ctor()
        {
            Assert.NotNull(new UnitTestException());
        }
        
        [Fact]
        public void ctor_string()
        {
            Assert.NotNull(new UnitTestException("message"));
        }

        [Fact]
        public void ctor_stringEmpty()
        {
            Assert.NotNull(new UnitTestException(string.Empty));
        }

        [Fact]
        public void ctor_stringEmpty_ExceptionNull()
        {
            Assert.NotNull(new UnitTestException(string.Empty, null));
        }

        [Fact]
        public void ctor_stringNull()
        {
            Assert.NotNull(new UnitTestException(null));
        }

        [Fact]
        public void ctor_stringNull_ExceptionNull()
        {
            Assert.NotNull(new UnitTestException(null, null));
        }

        [Fact]
        public void ctor_string_Exception()
        {
            Assert.NotNull(new UnitTestException("message", new InvalidOperationException()));
        }

        [Fact]
        public void ctor_string_ExceptionNull()
        {
            Assert.NotNull(new UnitTestException("message", null));
        }
    }
}