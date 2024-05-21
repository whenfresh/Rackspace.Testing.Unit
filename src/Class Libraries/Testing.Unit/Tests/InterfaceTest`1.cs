namespace WhenFresh.Rackspace.Tests
{
    using System.Globalization;
    using WhenFresh.Rackspace.Fluent;
    using WhenFresh.Rackspace.Properties;

    public sealed class InterfaceTest<T> : ITestExpectation
    {
        public bool Check()
        {
            if (typeof(T).IsInterface)
            {
                return true;
            }

            throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.InterfaceTestException_Message, typeof(T).Name));
        }
    }
}