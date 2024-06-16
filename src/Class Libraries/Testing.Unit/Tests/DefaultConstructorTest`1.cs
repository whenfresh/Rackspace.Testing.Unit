namespace WhenFresh.Utilities.Testing.Unit.Tests
{
    using System;
    using System.Globalization;
    using WhenFresh.Utilities.Testing.Unit.Fluent;
    using WhenFresh.Utilities.Testing.Unit.Properties;

    public sealed class DefaultConstructorTest<T> : ITestExpectation
    {
        public bool Check()
        {
            if (null == typeof(T).GetConstructor(Type.EmptyTypes))
            {
                throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.DefaultConstructorTestException_Message, typeof(T).Name));
            }

            return true;
        }
    }
}