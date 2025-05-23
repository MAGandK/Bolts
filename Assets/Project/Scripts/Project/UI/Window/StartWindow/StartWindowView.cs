using Project.UI.Controller;
using Project.UI.Other;
using Project.UI.Window.StartWindow.Elements;
using UnityEngine;
using UnityEngine.UI;

namespace Project.UI.Window.StartWindow
{
    public class StartWindowView : AbstractWindowView
    {
        [SerializeField] private LevelProgressBar _levelProgressBar;
        [SerializeField] private Button _startButton;
        [SerializeField] private Button _settingWindowButton;
        [SerializeField] private Button _giftWindowButton;
        [SerializeField] private BalanceView _balanceView;

        public BalanceView BalanceView => _balanceView;
        public Button StartButton => _startButton;
        public Button GiftButton => _giftWindowButton;
        public Button SettingWindowButton => _settingWindowButton;
        
        public void SetupProgressBar(int levelIndex)
        {
            _levelProgressBar.Setup(levelIndex);
        }
    }
}