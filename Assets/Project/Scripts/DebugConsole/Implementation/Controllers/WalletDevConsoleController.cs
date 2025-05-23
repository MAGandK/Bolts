using Constants;
using Project.Storage;
using Project.Storage.Data.Implementation;

namespace DebugConsole.Controllers
{
    public class WalletDevConsoleController : IDevConsoleController
    {
        private WalletStorageData _walletStorageData;
        
        public WalletDevConsoleController(IStorageService storageService)
        {
            _walletStorageData = storageService.GetData<WalletStorageData>(StorageDataNames.WALLET_STORAGE_DATA_KEY);
        }

        public void Init()
        {
           
        }
    }
}