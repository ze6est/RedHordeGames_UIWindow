using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase
{
    public class ItemView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _title;
        [SerializeField] private TextMeshProUGUI _description;
        [SerializeField] private Image _icon;
        [SerializeField] private BuyButton _button;

        public BuyButton Button => _button;

        public void SetTitle(string title) => 
            _title.text = title;

        public void SetDescription(string description) => 
            _description.text = description;

        public void SetIcon(Sprite icon) => 
            _icon.sprite = icon;
    }
}
