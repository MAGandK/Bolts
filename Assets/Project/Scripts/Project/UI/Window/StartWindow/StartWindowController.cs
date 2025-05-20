using System;
using Constants;
using Project.Storage;
using Project.Storage.Data.Implementation;
using Project.Storage.Price;
using Project.UI.Controller;
using Project.UI.OfflineGiftPopup;
using Project.UI.Window.GameWindow;
using Project.UI.Window.SettingPopup;

namespace Project.UI.Window.StartWindow
{
    public class StartWindowController : AbstractWindowController<StartWindowView>
    {
        public event Action StartClicked;

        private readonly StartWindowView _view;
        private readonly LevelProgressStorageData _levelProgressStorageData;

        public StartWindowController(
            StartWindowView view,
            IStorageService storageService) : base(view)
        {
            _view = view;
            _levelProgressStorageData =
                storageService.GetData<LevelProgressStorageData>(StorageDataNames.LEVEL_PROGRESS_STORAGE_DATA_KEY);
        }

        public override void Initialize()
        {
            base.Initialize();
            _view.StartButton.onClick.AddListener(OnStartButtonClick);
            _view.SettingWindowButton.onClick.AddListener(OnSettingButtonClick);
            _view.GiftButton.onClick.AddListener(OnGiftButtonClick);
            _view.BalanceView.Setup(CurrencyType.coin, CurrencyType.rybi);
        }

        private void OnGiftButtonClick()
        {
            _uiController.ShowWindow<OfflineGiftPopupController>();
        }

        private void OnSettingButtonClick()
        {
            _uiController.ShowWindow<SettingPopupController>();
        }

        protected override void OnShow()
        {
            base.OnShow();
            _view.SetupProgressBar(_levelProgressStorageData.LevelIndex);
        }

        private void OnStartButtonClick()
        {
            _uiController.ShowWindow<GameWindowController>();
            StartClicked?.Invoke();
        }
    }
}