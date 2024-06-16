﻿namespace WhenFresh.Rackspace.Testing.Unit.Facts.Fluent
{
    using Moq;
    using WhenFresh.Rackspace.Testing.Unit;
    using WhenFresh.Rackspace.Testing.Unit.Fluent;
    using Xunit;

    public sealed class ITestClassStyleFacts
    {
        [Fact]
        public void a_definition()
        {
            Assert.True(new TypeExpectations<ITestClassStyle>()
                            .IsInterface()
                            .Result);
        }

        [Fact]
        public void op_IsAbstractBaseClass()
        {
            var expected = new Mock<ITestType>().Object;

            var mock = new Mock<ITestClassStyle>();
            mock
                .Setup(x => x.IsAbstractBaseClass())
                .Returns(expected)
                .Verifiable();

            var actual = mock.Object.IsAbstractBaseClass();

            Assert.Equal(expected, actual);

            mock.VerifyAll();
        }

        [Fact]
        public void op_IsConcreteClass()
        {
            var expected = new Mock<ITestClassSealed>().Object;

            var mock = new Mock<ITestClassStyle>();
            mock
                .Setup(x => x.IsConcreteClass())
                .Returns(expected)
                .Verifiable();

            var actual = mock.Object.IsConcreteClass();

            Assert.Equal(expected, actual);

            mock.VerifyAll();
        }
    }
}