using RedHordeGames_UIWindow.CodeBase.Factories.Items;
using RedHordeGames_UIWindow.CodeBase.Factories.Windows;
using RedHordeGames_UIWindow.CodeBase.Items;
using RedHordeGames_UIWindow.CodeBase.Windows;
using RedHordeGames_UIWindow.CodeBase.Windows.MainWindow;
using RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow;
using UnityEngine;
using Zenject;

namespace RedHordeGames_UIWindow.CodeBase.Installers
{
    public class Installer : MonoInstaller
    {
        [Header("Items")]
        [SerializeField] private ItemView _itemPrefab;

        [Header("Windows")] 
        [SerializeField] private MainWindowView _mainWindowView;
        [SerializeField] private UpgradesWindowView _upgradesWindowView;
        [SerializeField] private UpgradesWindowModel _upgradesWindowModel;
        [SerializeField] private Background _background;

        private ItemBuyer _buyer;
        private Wallet _wallet;

        public override void InstallBindings()
        {
            Container.Bind<MainWindowView>().FromInstance(_mainWindowView);
            Container.Bind<UpgradesWindowView>().FromInstance(_upgradesWindowView);
            Container.Bind<UpgradesWindowModel>().FromInstance(_upgradesWindowModel);
            Container.Bind<Background>().FromInstance(_background);
            
            Container.Bind<WindowsManager>().AsSingle().NonLazy();
            
            Container.Bind<ItemBuyer>().AsSingle().NonLazy();
            
            Container.Bind<Wallet>().AsSingle().NonLazy();

            Container.Bind<ItemViewFactory>().AsSingle().WithArguments(_itemPrefab);
            Container.Bind<ItemPresenterFactory>().AsSingle();
            Container.Bind<MainWindowPresenterFactory>().AsSingle();
            Container.Bind<UpgradesWindowPresenterFactory>().AsSingle();
        }
    }
}
