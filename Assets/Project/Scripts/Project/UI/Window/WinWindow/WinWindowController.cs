using System;
using Project.UI.Controller;
using Project.UI.Window.GameWindow;

namespace Project.UI.Window.WinWindow
{
    public class WinWindowController : AbstractWindowController<WinWindowView>
    {
        public event Action Won; 
        
        private readonly WinWindowView _winView;

        public WinWindowController(WinWindowView view) : base(view)
        {
            _winView = view;
        }

        public override void Initialize()
        {
            base.Initialize();
            
            _winView.SubscribeButton(OnContinueButtonClick, OnRewardButtonClick);
            
        }

        private void OnContinueButtonClick()
        {
            _uiController.ShowWindow<GameWindowController>();
            Won?.Invoke();
        }
        
        private void OnRewardButtonClick()
        {
                
        }
    }
}