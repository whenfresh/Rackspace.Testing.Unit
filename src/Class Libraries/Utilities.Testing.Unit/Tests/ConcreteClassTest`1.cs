namespace WhenFresh.Utilities.Testing.Unit.Tests
{
    using System.Globalization;
    using WhenFresh.Utilities.Testing.Unit.Fluent;
    using WhenFresh.Utilities.Testing.Unit.Properties;

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