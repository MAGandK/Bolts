using DG.Tweening;
using Project.UI.OfflineGiftPopup;
using UnityEngine;

namespace Project.UI.Controller
{
    public abstract class AbstractPopupController<T> : AbstractWindowController<T>, IPopupController where T : IWindowView
    {
        [Space] private T _baseView;
        private Tweener _showTween;
        
        protected AbstractPopupController(T view) : base(view)
        {
            _baseView = view;
        }

        public void SetOrderInLayer(int order)
        {
            _baseView.SetOrderInLayer(order);
        }
    }
}