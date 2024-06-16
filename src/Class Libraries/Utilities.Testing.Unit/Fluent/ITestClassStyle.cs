namespace WhenFresh.Rackspace.Testing.Unit.Fluent
{
    public interface ITestClassStyle
    {
        ITestType IsAbstractBaseClass();

        ITestClassSealed IsConcreteClass();
    }
}