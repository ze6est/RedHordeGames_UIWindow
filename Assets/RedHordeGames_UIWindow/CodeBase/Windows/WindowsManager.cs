using System;
using RedHordeGames_UIWindow.CodeBase.Factories.Windows;
using RedHordeGames_UIWindow.CodeBase.Windows.MainWindow;
using RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow;
using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase.Windows
{
    public class WindowsManager : IDisposable
    {
        private MainWindowView _mainWindow;
        private UpgradesWindowView _upgradesWindowView;
        private Background _background;
        
        private Button _shopCloseButton;

        public WindowsManager(MainWindowView mainWindow, UpgradesWindowView upgradesWindowView, 
            Background background, UpgradesWindowPresenterFactory upgradesWindowPresenterFactory)
        {
            _mainWindow = mainWindow;
            _upgradesWindowView = upgradesWindowView;
            UpgradesWindowPresenter upgradesWindowPresenter = upgradesWindowPresenterFactory.Create();
            upgradesWindowPresenter.Init();
            
            _background = background;
            
            HideWindow();
            
            _mainWindow.UpgradesOpenButton.onClick.AddListener(ShowWindow);
            _upgradesWindowView.CloseButton.onClick.AddListener(HideWindow);
            _background.Clicked += HideWindow;
        }
        
        public void Dispose()
        {
            _mainWindow.UpgradesOpenButton.onClick.RemoveListener(ShowWindow);
            _shopCloseButton.onClick.RemoveListener(HideWindow);
            _background.Clicked -= HideWindow;
        }

        private void ShowWindow()
        {
            _upgradesWindowView.Show();
            _mainWindow.Hide();
        }

        private void HideWindow()
        {
            _mainWindow.Show();
            _upgradesWindowView.Hide();
        }
    }
}
