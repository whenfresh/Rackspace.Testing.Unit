namespace WhenFresh.Utilities.Testing.Unit.Tests
{
    using System.Globalization;
    using WhenFresh.Utilities.Testing.Unit.Fluent;
    using WhenFresh.Utilities.Testing.Unit.Properties;

    public sealed class ValueTypeTest<T> : ITestExpectation
    {
        public bool Check()
        {
            if (typeof(T).IsValueType)
            {
                return true;
            }

            throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.ValueTypeTestException_Message, typeof(T).Name));
        }
    }
}