﻿namespace WhenFresh.Utilities.Testing.Unit.Tests
{
    using System;
    using System.Globalization;
    using System.Reflection;
    using WhenFresh.Utilities.Testing.Unit.Properties;

    public sealed class PropertyGetterTest : PropertyTestBase
    {
        public PropertyGetterTest(PropertyInfo property,
                                  object expected)
            : base(property)
        {
            Expected = expected;
        }

        public object Expected { get; set; }

        public override bool Check()
        {
            if (Equals(
                       Expected,
                       Property.GetGetMethod(true).Invoke(Activator.CreateInstance(Property.ReflectedType, true), null)))
            {
                return true;
            }

            throw new UnitTestException(string.Format(CultureInfo.InvariantCulture, Resources.PropertyGetterTestException_Message, Property.ReflectedType.Name, Property.Name));
        }
    }
}