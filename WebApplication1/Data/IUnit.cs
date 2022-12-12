namespace WebApplication1.Data
{
    public interface IUnit : IDisposable
    {
        IRepositoryStudent student { get; }
        bool complete();
    }
}
