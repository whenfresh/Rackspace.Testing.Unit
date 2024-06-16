namespace WhenFresh.Rackspace.Testing.Unit.Tests
{
    using System.Globalization;
    using WhenFresh.Rackspace.Testing.Unit.Fluent;
    using WhenFresh.Rackspace.Testing.Unit.Properties;

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