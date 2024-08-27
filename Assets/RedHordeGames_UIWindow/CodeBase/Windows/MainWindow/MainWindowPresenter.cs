using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase.Windows.MainWindow
{
    public class MainWindowPresenter
    {
        private MainWindowView _mainWindowView;
        
        public Button.ButtonClickedEvent UpgradesOpenButtonClick => 
            _mainWindowView.UpgradesOpenButtonClick;

        public MainWindowPresenter(MainWindowView mainWindowView) => 
            _mainWindowView = mainWindowView;

        public void ShowWindow() => 
            _mainWindowView.Show();

        public void HideWindow() => 
            _mainWindowView.Hide();
    }
}