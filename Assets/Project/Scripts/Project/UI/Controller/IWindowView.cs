namespace Project.UI.Controller
{
    public interface IWindowView
    {
        void Show();
        void Hide();
        void SetOrderInLayer(int order);
    }
}