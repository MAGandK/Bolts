using Project.Storage.Data;
using Zenject;

namespace Project.Storage
{
    public interface IStorageService : IInitializable
    {
        T GetData<T>(string key) where T : class, IStorageData;
    }
}