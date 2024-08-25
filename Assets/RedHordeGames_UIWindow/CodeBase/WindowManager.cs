using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase
{
    public class WindowManager : MonoBehaviour
    {
        [SerializeField] private ShopWindow _shopWindow;
        [SerializeField] private Button _shopOpenButton;
        [SerializeField] private Button _shopCloseButton;
        [SerializeField] private Background _background;

        private void OnEnable()
        {
            _shopOpenButton.onClick.AddListener(ShowWindow);
            _shopCloseButton.onClick.AddListener(HideWindow);
            _background.Clicked += HideWindow;
        }

        private void Start() => 
            HideWindow();

        private void OnDisable()
        {
            _shopOpenButton.onClick.RemoveListener(ShowWindow);
            _shopCloseButton.onClick.RemoveListener(HideWindow);
            _background.Clicked -= HideWindow;
        }

        private void ShowWindow()
        {
            _background.gameObject.SetActive(true);
            _shopWindow.transform.localScale = new Vector3(0.8f, 0.8f, 1f);
            _shopWindow.Show();
            _shopWindow.gameObject.SetActive(true);
            _shopWindow.transform.DOScale(Vector3.one, 1f).SetEase(Ease.OutBack);
        }

        private void HideWindow()
        {
            _shopWindow.Hide();
            HideBackground();
        }

        private void HideBackground() => 
            _background.gameObject.SetActive(false);
    }
}
