namespace WhenFresh.Rackspace.Testing.Unit.Facts.Tests
{
    using System;
    using System.Reflection;
    using WhenFresh.Rackspace.Testing.Unit.Tests;

    public sealed class DerivedPropertyTest : PropertyTestBase
    {
        public DerivedPropertyTest(PropertyInfo property)
            : base(property)
        {
        }

        public override bool Check()
        {
            throw new NotImplementedException();
        }
    }
}