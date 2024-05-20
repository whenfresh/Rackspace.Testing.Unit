namespace WhenFresh.Rackspace.Fluent
{
    public interface ITestClassConstruction
    {
        ITestType HasDefaultConstructor();

        ITestType NoDefaultConstructor();
    }
}