namespace Es.FwI
{
    public interface IIdGenerator
    {
        Id Create();
        void Create(Id commandId);
    }
}