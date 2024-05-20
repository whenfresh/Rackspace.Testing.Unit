namespace WhenFresh.Rackspace.Tests
{
    using System.Reflection;
    using WhenFresh.Rackspace.Fluent;

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