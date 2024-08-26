using System;
using RedHordeGames_UIWindow.CodeBase.Factories.Windows;
using RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow;
using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase.Windows
{
    public class WindowsManager : IDisposable
    {
        private UpgradesWindowView _upgradesWindowView;
        private Background _background;
        
        private Button _upgradesOpenButton;
        private Button _shopCloseButton;

        public WindowsManager(UpgradesWindowView upgradesWindowView, Background background, Button upgradesOpenButton, 
            UpgradesWindowPresenterFactory upgradesWindowPresenterFactory)
        {
            _upgradesWindowView = upgradesWindowView;
            UpgradesWindowPresenter upgradesWindowPresenter = upgradesWindowPresenterFactory.Create();
            upgradesWindowPresenter.Init();
            
            _background = background;
            _upgradesOpenButton = upgradesOpenButton;
            
            HideWindow();
            
            _upgradesOpenButton.onClick.AddListener(ShowWindow);
            _upgradesWindowView.CloseButton.onClick.AddListener(HideWindow);
            _background.Clicked += HideWindow;
        }
        
        public void Dispose()
        {
            _upgradesOpenButton.onClick.RemoveListener(ShowWindow);
            _shopCloseButton.onClick.RemoveListener(HideWindow);
            _background.Clicked -= HideWindow;
        }

        private void ShowWindow() => 
            _upgradesWindowView.Show();

        private void HideWindow() => 
            _upgradesWindowView.Hide();
    }
}
