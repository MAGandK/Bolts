using Project.UI.Controller;
using Project.UI.OfflineGiftPopup;
using Project.UI.Window.FailWindow;
using Project.UI.Window.GameWindow;
using Project.UI.Window.SettingPopup;
using Project.UI.Window.StartWindow;
using Project.UI.Window.WinWindow;
using Zenject;

namespace Project.Installers
{
    public class UIContextInstaller : MonoInstaller
    {
        public override void InstallBindings()
        {
            BindWindow<StartWindowController, StartWindowView>();
            BindWindow<GameWindowController, GameWindowView>();
            BindWindow<FailWindowController, FailWindowView>();
            BindWindow<WinWindowController, WinWindowView>();
            BindWindow<SettingPopupController, SettingPopupView>();
            BindWindow<OfflineGiftPopupController, OfflineGiftPopupView>();

            Container.Bind<IUIController>().To<UIController>().AsSingle().NonLazy();
        }

        private void BindWindow<TController, TWindowView>()
            where TController : IWindowController
            where TWindowView : IWindowView
        {
            Container.Bind(typeof(IWindowController), typeof(IInitializable)).To<TController>().AsSingle();
            Container.Bind<TWindowView>().FromComponentInHierarchy().AsSingle();
        }
    }
}