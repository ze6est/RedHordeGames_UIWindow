using RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow;

namespace RedHordeGames_UIWindow.CodeBase.Factories.Windows
{
    public class UpgradesWindowPresenterFactory
    {
        private UpgradesWindowView _upgradesWindowView;
        private UpgradesWindowModel _upgradesWindowModel;
        
        public UpgradesWindowPresenterFactory(UpgradesWindowView upgradesWindowView, UpgradesWindowModel upgradesWindowModel)
        {
            _upgradesWindowView = upgradesWindowView;
            _upgradesWindowModel = upgradesWindowModel;
        }
        
        public UpgradesWindowPresenter Create() => 
            new(_upgradesWindowView, _upgradesWindowModel);
    }
}