namespace RedHordeGames_UIWindow.CodeBase.Items
{
    public class ItemBuyer
    {
        private readonly Wallet _wallet;

        public ItemBuyer(Wallet wallet) => 
            _wallet = wallet;

        public void Buy(ItemModel itemModel)
        {
            if (CanBuy(itemModel))
                _wallet.SpendMoney(itemModel.Price);
        }

        public bool CanBuy(ItemModel itemModel) => 
            _wallet.Money >= itemModel.Price;
    }
}