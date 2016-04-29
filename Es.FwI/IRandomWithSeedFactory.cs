namespace Es.FwI
{
    public interface IRandomWithSeedFactory
    {
        IRandom Create(int seed);
    }
}