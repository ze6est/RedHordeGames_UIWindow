using UnityEngine;
using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase
{
    public class WindowManager : MonoBehaviour
    {
        [SerializeField] private ShopWindow _shopWindow;
        [SerializeField] private Button _shopOpenButton;
        [SerializeField] private Background _background;

        private void OnEnable()
        {
            _shopOpenButton.onClick.AddListener(_shopWindow.Show);
            _background.Clicked += OnClicked;
        }

        private void OnDisable()
        {
            _shopOpenButton.onClick.RemoveListener(_shopWindow.Show);
            _background.Clicked -= OnClicked;
        }

        private void OnClicked()
        {
            _shopWindow.Hide();
        }
    }
}
