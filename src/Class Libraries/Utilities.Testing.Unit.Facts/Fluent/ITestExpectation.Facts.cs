namespace WhenFresh.Rackspace.Testing.Unit.Facts.Fluent
{
    using Moq;
    using WhenFresh.Rackspace.Testing.Unit;
    using WhenFresh.Rackspace.Testing.Unit.Fluent;
    using Xunit;

    public sealed class ITestExpectationFacts
    {
        [Fact]
        public void a_definition()
        {
            Assert.True(new TypeExpectations<ITestExpectation>()
                            .IsInterface()
                            .Result);
        }

        [Fact]
        public void op_Check()
        {
            const bool expected = true;

            var mock = new Mock<ITestExpectation>();
            mock
                .Setup(x => x.Check())
                .Returns(expected)
                .Verifiable();

            var actual = mock.Object.Check();

            Assert.Equal(expected, actual);

            mock.VerifyAll();
        }
    }
}