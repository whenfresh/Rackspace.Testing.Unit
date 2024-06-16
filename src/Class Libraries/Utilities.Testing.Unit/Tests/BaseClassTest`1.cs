namespace WhenFresh.Utilities.Testing.Unit.Tests
{
    using System;
    using System.Globalization;
    using WhenFresh.Utilities.Testing.Unit.Fluent;
    using WhenFresh.Utilities.Testing.Unit.Properties;

    public sealed class BaseClassTest<T> : ITestExpectation
    {
        public BaseClassTest(Type @is)
        {
            Is = @is;
        }

        public Type Is { get; set; }

        public bool Check()
        {
            if (typeof(T).IsSubclassOf(Is))
            {
                return true;
            }

            throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.BaseClassTestException_Message, typeof(T).Name, Is.Name));
        }
    }
}