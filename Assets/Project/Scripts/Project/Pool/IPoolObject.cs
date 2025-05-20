namespace Project.Pool
{
    public interface IPoolObject
    {
        bool IsFree { get; }
        void SetIsFree(bool isFree);
    }
}