using System.Collections.Generic;
using DG.Tweening;
using RedHordeGames_UIWindow.CodeBase.Factories.Items;
using RedHordeGames_UIWindow.CodeBase.Items;
using UnityEngine;

namespace RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow
{
    public class UpgradesWindowPresenter : IWindow
    {
        private UpgradesWindowView _upgradesWindowView;
        private UpgradesWindowModel _upgradesWindowModel;

        private List<ItemPresenter> _presenters = new();
        private ItemCatalog _catalog;
        
        private ItemViewFactory _itemViewFactory;
        private ItemPresenterFactory _itemPresenterFactory;
        
        public UpgradesWindowPresenter(UpgradesWindowView upgradesWindowView, UpgradesWindowModel upgradesWindowModel, ItemCatalog catalog,
            ItemViewFactory itemViewFactory, ItemPresenterFactory itemPresenterFactory)
        {
            _upgradesWindowView = upgradesWindowView;
            _upgradesWindowModel = upgradesWindowModel;
            _catalog = catalog;

            _itemViewFactory = itemViewFactory;
            _itemPresenterFactory = itemPresenterFactory;
            
            CreateItems();
        }

        public void Show()
        {
            _upgradesWindowView.transform.localScale = new Vector3(0.8f, 0.8f, 1f);
            _upgradesWindowView.gameObject.SetActive(true);
            _upgradesWindowView.transform.DOScale(Vector3.one, 1f).SetEase(Ease.OutBack);
            
            foreach (var presenter in _presenters)
                presenter.Enable();
        }

        public void Hide()
        {
            _upgradesWindowView.gameObject.SetActive(false);
            
            foreach (var presenter in _presenters)
                presenter.Disable();
        }
        
        private void CreateItems()
        {
            List<ItemModel> items = _catalog.Items;

            foreach (ItemModel item in items)
            {
                ItemView view = _itemViewFactory.Create();
                ItemPresenter presenter = _itemPresenterFactory.Create(view, item);
                presenter.ItemBuyed += OnItemBuyed;
                _presenters.Add(presenter);
            }
        }

        private void OnItemBuyed(ItemView item, ItemPresenter presenter)
        {
            item.gameObject.SetActive(false);
            presenter.ItemBuyed -= OnItemBuyed; }
    }
}