namespace WhenFresh.Utilities.Testing.Unit.Tests
{
    using System.Globalization;
    using WhenFresh.Utilities.Testing.Unit.Fluent;
    using WhenFresh.Utilities.Testing.Unit.Properties;

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