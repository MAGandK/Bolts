namespace Project.UI.Controller
{
    public interface IWindowController
    { 
        void Show();
        void Hide();
        void SetUIController(UIController uiController);
    }
}