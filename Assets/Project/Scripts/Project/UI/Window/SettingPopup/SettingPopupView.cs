using Project.UI.Controller;
using Project.UI.Other;
using Project.UI.Other.UIAnimation;
using UnityEngine;
using UnityEngine.UI;

namespace Project.UI.Window.SettingPopup
{
    public class SettingPopupView : AbstractWindowView
    {
        [SerializeField] private ToggleButton _muteSoundButton;
        [SerializeField] private ToggleButton _muteMusicButton;
        [SerializeField] private Button _backButton;
        [SerializeField] private ShowPopupAnimation _popupAnimation;
        
        public ToggleButton MuteSoundButton => _muteSoundButton;
        public ToggleButton MuteMusicButton => _muteMusicButton;
        public Button BackButton => _backButton;
        public ShowPopupAnimation PopupAnimation => _popupAnimation;
    }
}