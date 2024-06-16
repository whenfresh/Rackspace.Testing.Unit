namespace WhenFresh.Utilities.Testing.Unit.Fluent
{
    public interface ITestClassConstruction
    {
        ITestType HasDefaultConstructor();

        ITestType NoDefaultConstructor();
    }
}