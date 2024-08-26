using System.Collections.Generic;
using DG.Tweening;
using RedHordeGames_UIWindow.CodeBase.Factories.Items;
using RedHordeGames_UIWindow.CodeBase.Items;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow
{
    public class UpgradesWindowView : MonoBehaviour, IWindow
    {
        [SerializeField] private TextMeshProUGUI _title;
        [SerializeField] private Button _closeButton;
        [SerializeField] private ItemCatalog _catalog;
        [SerializeField] private GameObject _menu;
        [SerializeField] private Transform _content;
        
        private List<ItemPresenter> _presenters = new();
        private ItemViewFactory _itemViewFactory;
        private ItemPresenterFactory _itemPresenterFactory;

        public Button CloseButton => _closeButton;

        [Inject]
        public void Construct(ItemViewFactory itemViewFactory, ItemPresenterFactory itemPresenterFactory)
        {
            _itemViewFactory = itemViewFactory;
            _itemPresenterFactory = itemPresenterFactory;
        }
        
        private void Awake() => 
            CreateItems();

        public void SetTitle(string title) => 
            _title.text = title;
        
        public void Show()
        {
            gameObject.SetActive(true);
            _menu.transform.localScale = new Vector3(0.8f, 0.8f, 1f);
            _menu.transform.DOScale(Vector3.one, 1f).SetEase(Ease.OutBack);
            
            foreach (var presenter in _presenters)
                presenter.Enable();
        }

        public void Hide()
        {
            gameObject.SetActive(false);
            
            foreach (var presenter in _presenters)
                presenter.Disable();
        }
        
        private void CreateItems()
        {
            List<ItemModel> items = _catalog.Items;

            foreach (ItemModel item in items)
            {
                ItemView view = _itemViewFactory.Create(_content);
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
