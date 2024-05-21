namespace WhenFresh.Rackspace.Fluent
{
    public interface ITestClassSealed
    {
        ITestClassConstruction IsSealed();

        ITestClassConstruction IsUnsealed();
    }
}