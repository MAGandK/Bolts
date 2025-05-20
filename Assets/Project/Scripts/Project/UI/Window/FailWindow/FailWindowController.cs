using System;
using Project.LevelLoad;
using Project.UI.Controller;
using Project.UI.Window.StartWindow;

namespace Project.UI.Window.FailWindow
{
    public class FailWindowController : AbstractWindowController<FailWindowView>
    {
        public event Action RetryClicked;
        
        private FailWindowView _failWindowView;
        private ILevelLoader _levelLoader;

        public FailWindowController(FailWindowView view, ILevelLoader levelLoader) : base(view)
        {
            _levelLoader = levelLoader;
            _failWindowView = view;
        }

        public override void Initialize()
        {
            base.Initialize();
            
            _failWindowView.SubscribeButton(OnRetryButtonClick, OnNoTryButtonClick);
        }

        private void OnNoTryButtonClick()
        {
            _levelLoader.LoadCurrentLevel();
            _uiController.ShowWindow<StartWindowController>();
        }

        private void OnRetryButtonClick()
        {
            _levelLoader.LoadCurrentLevel();
            _uiController.ShowWindow<StartWindowController>();
        }

        protected virtual void OnRetryClicked()
        {
            RetryClicked?.Invoke();
        }
    }
}