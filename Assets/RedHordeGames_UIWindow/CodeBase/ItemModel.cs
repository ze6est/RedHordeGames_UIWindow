using UnityEngine;

namespace RedHordeGames_UIWindow.CodeBase
{
    [CreateAssetMenu(menuName = "Create Item", fileName = "Item", order = 51)]
    public class ItemModel : ScriptableObject
    {
        public string Title;
        public string DescriptionSlim;
        public Sprite Icon;
        public float Price;
    }
}