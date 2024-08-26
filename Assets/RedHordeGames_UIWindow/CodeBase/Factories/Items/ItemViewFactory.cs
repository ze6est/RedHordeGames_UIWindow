using RedHordeGames_UIWindow.CodeBase.Items;
using UnityEngine;

namespace RedHordeGames_UIWindow.CodeBase.Factories.Items
{
    public class ItemViewFactory
    {
        private ItemView _prefab;

        public ItemViewFactory(ItemView prefab) => 
            _prefab = prefab;

        public ItemView Create(Transform container) =>
            Object.Instantiate(_prefab, container);
    }
}