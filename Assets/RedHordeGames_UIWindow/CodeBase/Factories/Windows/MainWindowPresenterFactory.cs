using RedHordeGames_UIWindow.CodeBase.Windows.MainWindow;

namespace RedHordeGames_UIWindow.CodeBase.Factories.Windows
{
    public class MainWindowPresenterFactory
    {
        private MainWindowView _mainWindowView;

        public MainWindowPresenterFactory(MainWindowView mainWindowView)
        {
            _mainWindowView = mainWindowView;
        }
        
        public MainWindowPresenter Create() => 
            new(_mainWindowView);
    }
}