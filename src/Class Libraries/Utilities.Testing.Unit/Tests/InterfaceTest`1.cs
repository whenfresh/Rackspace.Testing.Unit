namespace WhenFresh.Rackspace.Testing.Unit.Tests
{
    using System.Globalization;
    using WhenFresh.Rackspace.Testing.Unit.Fluent;
    using WhenFresh.Rackspace.Testing.Unit.Properties;

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