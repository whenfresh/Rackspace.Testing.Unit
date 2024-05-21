namespace WhenFresh.Rackspace.Tests
{
    using System.Globalization;
    using WhenFresh.Rackspace.Fluent;
    using WhenFresh.Rackspace.Properties;

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