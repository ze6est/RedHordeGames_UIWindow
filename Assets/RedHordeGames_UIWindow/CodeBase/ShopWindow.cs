using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace RedHordeGames_UIWindow.CodeBase
{
    public class ShopWindow : Window
    {
        [SerializeField] private ItemView _itemPrefab;
        [SerializeField] private Transform _itemContainer;

        private List<ItemPresenter> _presenters = new();
        private ItemCatalog _catalog;
        private ItemBuyer _buyer;
        private Wallet _wallet;

        [Inject]
        public void Construct(ItemBuyer buyer, Wallet wallet, ItemCatalog catalog)
        {
            _buyer = buyer;
            _wallet = wallet;
            _catalog = catalog;
        }

        private void Awake()
        {
            CreateItems();
        }

        public override void Show()
        {
            gameObject.SetActive(true);
            
            foreach (var presenter in _presenters)
            {
                presenter.Enable();
            }
        }

        public override void Hide()
        {
            gameObject.SetActive(false);
            
            foreach (var presenter in _presenters)
            {
                presenter.Disable();
            }
        }
        
        private void CreateItems()
        {
            List<ItemModel> items = _catalog.Items;

            foreach (ItemModel item in items)
            {
                ItemView view = Instantiate(_itemPrefab, _itemContainer);
                ItemPresenter presenter = new ItemPresenter(view, item, _buyer, _wallet);
                _presenters.Add(presenter);
            }
        }
    }
}