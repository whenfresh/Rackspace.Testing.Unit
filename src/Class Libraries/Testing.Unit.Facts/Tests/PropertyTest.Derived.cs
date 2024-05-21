namespace Testing.Unit.Facts.Tests
{
    using System;
    using System.Reflection;
    using WhenFresh.Rackspace.Tests;

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