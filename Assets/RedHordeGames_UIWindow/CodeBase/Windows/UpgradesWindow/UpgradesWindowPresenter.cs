namespace RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow
{
    public class UpgradesWindowPresenter
    {
        private UpgradesWindowView _upgradesWindowView;
        private UpgradesWindowModel _upgradesWindowModel;
        
        public UpgradesWindowPresenter(UpgradesWindowView upgradesWindowView, UpgradesWindowModel upgradesWindowModel)
        {
            _upgradesWindowView = upgradesWindowView;
            _upgradesWindowModel = upgradesWindowModel;
        }

        public void Init() => 
            _upgradesWindowView.SetTitle(_upgradesWindowModel.Title);
    }
}