using System.Collections.Generic;
using UnityEngine;

namespace RedHordeGames_UIWindow.CodeBase.Items
{
    [CreateAssetMenu(menuName = "Create items catalog", fileName = "ItemsCatalog", order = 51)]
    public class ItemCatalog : ScriptableObject
    {
        public List<ItemModel> Items;
    }
}