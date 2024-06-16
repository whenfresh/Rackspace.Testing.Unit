namespace WhenFresh.Rackspace.Testing.Unit.Tests
{
    using System.Globalization;
    using WhenFresh.Rackspace.Testing.Unit.Fluent;
    using WhenFresh.Rackspace.Testing.Unit.Properties;

    public sealed class ConcreteClassTest<T> : ITestExpectation
    {
        public bool Check()
        {
            if (typeof(T).IsAbstract)
            {
                throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.ConcreteClassTestException_Message, typeof(T).Name));
            }

            return true;
        }
    }
}