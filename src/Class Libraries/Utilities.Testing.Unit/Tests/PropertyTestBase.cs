namespace WhenFresh.Rackspace.Testing.Unit.Tests
{
    using System.Reflection;
    using WhenFresh.Rackspace.Testing.Unit.Fluent;

    public abstract class PropertyTestBase : ITestExpectation
    {
        protected PropertyTestBase(PropertyInfo property)
        {
            Property = property;
        }

        public PropertyInfo Property { get; set; }

        public abstract bool Check();
    }
}