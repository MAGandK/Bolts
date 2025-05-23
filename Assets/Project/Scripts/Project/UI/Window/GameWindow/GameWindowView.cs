using Project.UI.Controller;
using Project.UI.Other;
using TMPro;
using UnityEngine;

namespace Project.UI.Window.GameWindow
{
    public class GameWindowView : AbstractWindowView
    {
        [SerializeField] private TMP_Text _scoreText;
        [SerializeField] private BalanceView _balanceView;

        /*public void SetBalance()
        {
            _balanceView.Setup(CurrencyType.coin,CurrencyType.rybi);
        }*/
        public void RefreshScore(int score)
        {
            _scoreText.SetText(score.ToString());
        }
    }
}