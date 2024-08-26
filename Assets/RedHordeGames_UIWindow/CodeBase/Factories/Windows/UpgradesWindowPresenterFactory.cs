using RedHordeGames_UIWindow.CodeBase.Factories.Items;
using RedHordeGames_UIWindow.CodeBase.Items;
using RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow;

namespace RedHordeGames_UIWindow.CodeBase.Factories.Windows
{
    public class UpgradesWindowPresenterFactory
    {
        private UpgradesWindowView _upgradesWindowView;
        private UpgradesWindowModel _upgradesWindowModel;
        private ItemCatalog _itemCatalog;
        private ItemViewFactory _itemViewFactory;
        private ItemPresenterFactory _itemPresenterFactory;
        
        public UpgradesWindowPresenterFactory(UpgradesWindowView upgradesWindowView, UpgradesWindowModel upgradesWindowModel,
            ItemCatalog catalog, ItemViewFactory itemViewFactory, ItemPresenterFactory itemPresenterFactory)
        {
            _upgradesWindowView = upgradesWindowView;
            _upgradesWindowModel = upgradesWindowModel;
            _itemCatalog = catalog;
            _itemViewFactory = itemViewFactory;
            _itemPresenterFactory = itemPresenterFactory;
        }
        
        public UpgradesWindowPresenter Create()
        {
            return new UpgradesWindowPresenter(_upgradesWindowView, _upgradesWindowModel, _itemCatalog,
                _itemViewFactory, _itemPresenterFactory);
        }
    }
}