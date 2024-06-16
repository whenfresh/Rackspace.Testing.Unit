namespace WhenFresh.Rackspace.Testing.Unit.Fluent
{
    public interface ITestClassSealed
    {
        ITestClassConstruction IsSealed();

        ITestClassConstruction IsUnsealed();
    }
}