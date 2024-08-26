using RedHordeGames_UIWindow.CodeBase.Items;
using UnityEngine;

namespace RedHordeGames_UIWindow.CodeBase.Factories.Items
{
    public class ItemViewFactory
    {
        private ItemView _prefab;
        private Transform _container;
        
        public ItemViewFactory(ItemView prefab, Transform container)
        {
            _prefab = prefab;
            _container = container;
        }
        
        public ItemView Create() => 
            Object.Instantiate(_prefab, _container);
    }
}