namespace Es.FwI
{
    public interface IRefPool<T> where T : class
    {
        T Acquire();
        void Release(T t);
    }
}