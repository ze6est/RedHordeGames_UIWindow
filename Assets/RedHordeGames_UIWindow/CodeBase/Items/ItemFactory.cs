using UnityEngine;

namespace RedHordeGames_UIWindow.CodeBase.Items
{
    public class ItemFactory
    {
        public ItemView Create(ItemView _itemPrefab, Transform _itemContainer)
        {
            return Object.Instantiate(_itemPrefab, _itemContainer);
        }
    }
}