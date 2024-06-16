namespace WhenFresh.Utilities.Testing.Unit.Tests
{
    using System;
    using System.Reflection;
    using WhenFresh.Utilities.Testing.Unit.Fluent;

    public abstract class MemberTestBase : ITestExpectation
    {
        private MemberInfo _member;

        protected MemberTestBase(MemberInfo member)
        {
            Member = member;
        }

        public MemberInfo Member
        {
            get
            {
                return _member;
            }

            set
            {
                if (null == value)
                {
                    throw new ArgumentNullException("value");
                }

                _member = value;
            }
        }

        public abstract bool Check();
    }
}