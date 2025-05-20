using Project.UI.Controller;
using Project.UI.Other.UIAnimation;
using UnityEngine;
using UnityEngine.UI;

namespace Project.UI.OfflineGiftPopup
{
    public class OfflineGiftPopupView : AbstractWindowView
    {
        [SerializeField] private Button _closeButton;
        [SerializeField] private ShowPopupAnimation _showPopupAnimation;

        public ShowPopupAnimation ShowPopupAnimation => _showPopupAnimation;

        public Button CloseButton => _closeButton;
    }
}