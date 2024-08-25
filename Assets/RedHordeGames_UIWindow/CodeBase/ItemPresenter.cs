namespace RedHordeGames_UIWindow.CodeBase
{
    public class ItemPresenter
    {
        private readonly ItemView _itemView;
        private readonly ItemModel _itemModel;
        private readonly ItemBuyer _buyer;
        private readonly Wallet _wallet;

        public ItemPresenter(ItemView itemView, ItemModel itemModel, ItemBuyer buyer, Wallet wallet)
        {
            _itemView = itemView;
            _itemModel = itemModel;
            _buyer = buyer;
            _wallet = wallet;
        }

        public void Enable()
        {
            _wallet.MoneyChanged += OnMoneyChanged;
            _itemView.SetTitle(_itemModel.Title);
            _itemView.SetDescription(_itemModel.DescriptionSlim);
            _itemView.SetIcon(_itemModel.Icon);
            _itemView.Button.AddListener(OnBuyButtonClicked);
            _itemView.Button.SetPrice(_itemModel.Price.ToString());
            UpdateButtonState();
        }

        public void Disable()
        {
            _itemView.Button.RemoveListener(OnBuyButtonClicked);
            _wallet.MoneyChanged -= OnMoneyChanged;
        }
        
        private void OnBuyButtonClicked()
        {
            if (_buyer.CanBuy(_itemModel))
            {
                _buyer.Buy(_itemModel);
            }
        }
        
        private void OnMoneyChanged()
        {
            UpdateButtonState();
        }

        private void UpdateButtonState()
        {
            _itemView.Button.SetAvailable(_buyer.CanBuy(_itemModel));
        }
    }
}