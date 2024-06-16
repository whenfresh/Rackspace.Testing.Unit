﻿namespace WhenFresh.Rackspace.Testing.Unit.Tests
{
    using System;
    using System.Globalization;
    using WhenFresh.Rackspace.Testing.Unit.Fluent;
    using WhenFresh.Rackspace.Testing.Unit.Properties;

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