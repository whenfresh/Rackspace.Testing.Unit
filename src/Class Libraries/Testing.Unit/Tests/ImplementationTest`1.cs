namespace WhenFresh.Utilities.Testing.Unit.Tests
{
    using System;
    using System.Globalization;
    using WhenFresh.Utilities.Testing.Unit.Fluent;
    using WhenFresh.Utilities.Testing.Unit.Properties;

    public sealed class ImplementationTest<T> : ITestExpectation
    {
        public ImplementationTest(Type @interface)
        {
            Interface = @interface;
        }

        public Type Interface { get; set; }

        public bool Check()
        {
            if (null == Interface)
            {
                if (0 != typeof(T).GetInterfaces().Length)
                {
                    throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.ImplementationTestException_UnexpectedMessage, typeof(T).Name));
                }
            }
            else
            {
                if (!typeof(T).Implements(Interface))
                {
                    throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.ImplementationTestException_NoneMessage, typeof(T).Name, Interface.Name));
                }
            }

            return true;
        }
    }
}