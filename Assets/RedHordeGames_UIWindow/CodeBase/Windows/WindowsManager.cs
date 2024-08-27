using System;
using RedHordeGames_UIWindow.CodeBase.Factories.Windows;
using RedHordeGames_UIWindow.CodeBase.Windows.MainWindow;
using RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow;
using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase.Windows
{
    public class WindowsManager : IDisposable
    {
        private Background _background;
        private UpgradesWindowPresenter _upgradesWindowPresenter;
        private MainWindowPresenter _mainWindowPresenter;

        private Button _shopCloseButton;

        public WindowsManager(Background background, UpgradesWindowPresenterFactory upgradesWindowPresenterFactory, 
            MainWindowPresenterFactory mainWindowPresenterFactory)
        {
            _mainWindowPresenter = mainWindowPresenterFactory.Create();
            _mainWindowPresenter.UpgradesOpenButtonClick.AddListener(ShowUpgrades);

            _upgradesWindowPresenter = upgradesWindowPresenterFactory.Create();
            _upgradesWindowPresenter.Init();
            _upgradesWindowPresenter.CloseButtonClick.AddListener(ShowMain);

            _background = background;
            _background.Clicked += ShowMain;

            ShowMain();
        }

        public void Dispose()
        {
            _mainWindowPresenter.UpgradesOpenButtonClick.RemoveListener(ShowUpgrades);
            _shopCloseButton.onClick.RemoveListener(ShowMain);
            _background.Clicked -= ShowMain;
        }

        private void ShowUpgrades()
        {
            _upgradesWindowPresenter.ShowWindow();
            _mainWindowPresenter.HideWindow();
        }

        private void ShowMain()
        {
            _mainWindowPresenter.ShowWindow();
            _upgradesWindowPresenter.HideWindow();
        }
    }
}