namespace WhenFresh.Rackspace.Testing.Unit.Fluent
{
    public interface ITestClassConstruction
    {
        ITestType HasDefaultConstructor();

        ITestType NoDefaultConstructor();
    }
}