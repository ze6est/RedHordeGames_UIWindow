using RedHordeGames_UIWindow.CodeBase.Items;

namespace RedHordeGames_UIWindow.CodeBase.Factories.Items
{
    public class ItemPresenterFactory
    {
        private ItemBuyer _buyer;
        private Wallet _wallet;
        
        public ItemPresenterFactory(ItemBuyer buyer, Wallet wallet)
        {
            _buyer = buyer;
            _wallet = wallet;
        }
        
        public ItemPresenter Create(ItemView view, ItemModel model) => 
            new(view, model, _buyer, _wallet);
    }
}