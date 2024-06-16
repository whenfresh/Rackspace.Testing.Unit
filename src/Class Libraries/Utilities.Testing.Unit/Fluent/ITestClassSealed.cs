namespace WhenFresh.Utilities.Testing.Unit.Fluent
{
    public interface ITestClassSealed
    {
        ITestClassConstruction IsSealed();

        ITestClassConstruction IsUnsealed();
    }
}