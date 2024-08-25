using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase
{
    public class BuyButton : MonoBehaviour
    {
        [SerializeField] private Button _button;
        [SerializeField] private TextMeshProUGUI _priceText;
        [SerializeField] private Image _priceIcon;
        [SerializeField] private State _state;

        public void AddListener(UnityAction action) => 
            _button.onClick.AddListener(action);

        public void RemoveListener(UnityAction action) => 
            _button.onClick.RemoveListener(action);

        public void SetPrice(string price) => 
            _priceText.text = price;

        public void SetIcon(Sprite icon) => 
            _priceIcon.sprite = icon;

        public void SetAvailable(bool isAvailable)
        {
            State state = isAvailable ? State.AVAILABLE : State.LOCKED;
            SetState(state);
        }

        private void SetState(State state)
        {
            _state = state;

            if (_state == State.AVAILABLE)
                _button.interactable = true;
            else
                _button.interactable = false;
        }
    }

    public enum State
    {
        AVAILABLE,
        LOCKED
    }
}
