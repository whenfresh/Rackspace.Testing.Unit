namespace WhenFresh.Rackspace.Fluent
{
    public interface ITestClassStyle
    {
        ITestType IsAbstractBaseClass();

        ITestClassSealed IsConcreteClass();
    }
}