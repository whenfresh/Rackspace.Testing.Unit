namespace WhenFresh.Utilities.Testing.Unit.Tests
{
    using System.Globalization;
    using WhenFresh.Utilities.Testing.Unit.Fluent;
    using WhenFresh.Utilities.Testing.Unit.Properties;

    public sealed class AbstractBaseClassTest<T> : ITestExpectation
    {
        public bool Check()
        {
            if (!typeof(T).IsAbstract ||
                typeof(T).IsSealed)
            {
                throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.AbstractBaseClassTestException_Message, typeof(T).Name));
            }

            return true;
        }
    }
}