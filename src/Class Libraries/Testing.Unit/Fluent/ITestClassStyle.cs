namespace WhenFresh.Utilities.Testing.Unit.Fluent
{
    public interface ITestClassStyle
    {
        ITestType IsAbstractBaseClass();

        ITestClassSealed IsConcreteClass();
    }
}