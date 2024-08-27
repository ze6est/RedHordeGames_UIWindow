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
            _mainWindow.UpgradesOpenButtonClick.AddListener(ShowUpgrades);
            
            _upgradesWindowView = upgradesWindowView;
            _upgradesWindowView.CloseButtonClick.AddListener(ShowMain);
            
            UpgradesWindowPresenter upgradesWindowPresenter = upgradesWindowPresenterFactory.Create();
            upgradesWindowPresenter.Init();
            
            _background = background;
            _background.Clicked += ShowMain;
            
            ShowMain();
        }
        
        public void Dispose()
        {
            _mainWindow.UpgradesOpenButtonClick.RemoveListener(ShowUpgrades);
            _shopCloseButton.onClick.RemoveListener(ShowMain);
            _background.Clicked -= ShowMain;
        }

        private void ShowUpgrades()
        {
            _upgradesWindowView.Show();
            _mainWindow.Hide();
        }

        private void ShowMain()
        {
            _mainWindow.Show();
            _upgradesWindowView.Hide();
        }
    }
}
