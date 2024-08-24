namespace RedHordeGames_UIWindow.CodeBase
{
    public class ItemPresenter
    {
        private readonly ItemView _itemView;
        private readonly ItemModel _itemModel;

        public ItemPresenter(ItemView itemView, ItemModel itemModel)
        {
            _itemView = itemView;
            _itemModel = itemModel;
        }

        public void Enable()
        {
            _itemView.SetTitle(_itemModel.Title);
            _itemView.SetDescription(_itemModel.DescriptionSlim);
            _itemView.SetIcon(_itemModel.Icon);
            _itemView.Button.AddListener(OnBuyButtonClicked);
            _itemView.Button.SetPrice(_itemModel.Price.ToString());
        }

        public void Disable()
        {
            _itemView.Button.RemoveListener(OnBuyButtonClicked);
        }
        
        private void OnBuyButtonClicked()
        {
            
        }
    }
}