namespace WhenFresh.Utilities.Testing.Unit.Facts.Tests
{
    using System;
    using System.Reflection;
    using WhenFresh.Utilities.Testing.Unit.Tests;

    public sealed class DerivedMemberTest : MemberTestBase
    {
        public DerivedMemberTest(MemberInfo property)
            : base(property)
        {
        }

        public override bool Check()
        {
            throw new NotImplementedException();
        }
    }
}