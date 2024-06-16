namespace WhenFresh.Utilities.Testing.Unit.Tests
{
    using System.Reflection;
    using WhenFresh.Utilities.Testing.Unit.Fluent;

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