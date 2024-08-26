using RedHordeGames_UIWindow.CodeBase.Factories.Items;
using RedHordeGames_UIWindow.CodeBase.Factories.Windows;
using RedHordeGames_UIWindow.CodeBase.Items;
using RedHordeGames_UIWindow.CodeBase.Windows;
using RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace RedHordeGames_UIWindow.CodeBase.Installers
{
    public class Installer : MonoInstaller
    {
        [Header("Items")]
        [SerializeField] private ItemView _itemPrefab;
        [Header("Windows")]
        [SerializeField] private UpgradesWindowView upgradesWindowView;
        [SerializeField] private UpgradesWindowModel upgradesWindowModel;
        [SerializeField] private Background _background;
        [SerializeField] private Button _upgradesOpenButton;

        private ItemBuyer _buyer;
        private Wallet _wallet;

        public override void InstallBindings()
        {
            Container.Bind<UpgradesWindowView>().FromInstance(upgradesWindowView);
            Container.Bind<UpgradesWindowModel>().FromInstance(upgradesWindowModel);
            Container.Bind<Background>().FromInstance(_background);
            
            Container.Bind<WindowsManager>().AsSingle().WithArguments(_upgradesOpenButton).NonLazy();
            
            Container.Bind<ItemBuyer>().AsSingle().NonLazy();
            
            Container.Bind<Wallet>().AsSingle().NonLazy();

            Container.Bind<ItemViewFactory>().AsSingle().WithArguments(_itemPrefab);
            Container.Bind<ItemPresenterFactory>().AsSingle();
            Container.Bind<UpgradesWindowPresenterFactory>().AsSingle();
        }
    }
}
