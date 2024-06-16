namespace WhenFresh.Rackspace.Testing.Unit.Tests
{
    using System.Globalization;
    using WhenFresh.Rackspace.Testing.Unit.Fluent;
    using WhenFresh.Rackspace.Testing.Unit.Properties;

    public sealed class SealedClassTest<T> : ITestExpectation
    {
        public SealedClassTest(bool value)
        {
            Value = value;
        }

        public bool Value { get; set; }

        public bool Check()
        {
            if (Value == typeof(T).IsSealed)
            {
                return true;
            }

            if (Value)
            {
                throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.SealedClassTestException_UnsealedMessage, typeof(T).Name));
            }

            throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.SealedClassTestException_SealedMessage, typeof(T).Name));
        }
    }
}