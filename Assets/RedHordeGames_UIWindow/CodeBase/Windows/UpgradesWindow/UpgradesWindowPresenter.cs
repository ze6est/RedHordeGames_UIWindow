using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow
{
    public class UpgradesWindowPresenter
    {
        private UpgradesWindowView _upgradesWindowView;
        private UpgradesWindowModel _upgradesWindowModel;

        public Button.ButtonClickedEvent CloseButtonClick => 
            _upgradesWindowView.CloseButtonClick;
        
        public UpgradesWindowPresenter(UpgradesWindowView upgradesWindowView, UpgradesWindowModel upgradesWindowModel)
        {
            _upgradesWindowView = upgradesWindowView;
            _upgradesWindowModel = upgradesWindowModel;
        }

        public void Init() => 
            _upgradesWindowView.SetTitle(_upgradesWindowModel.Title);

        public void ShowWindow() => 
            _upgradesWindowView.Show();

        public void HideWindow() => 
            _upgradesWindowView.Hide();
    }
}