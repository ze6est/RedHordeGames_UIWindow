using RedHordeGames_UIWindow.CodeBase.Items;
using UnityEngine;
using Zenject;

namespace RedHordeGames_UIWindow.CodeBase.Installers
{
    public class Installer : MonoInstaller
    {
        [SerializeField] private ItemCatalog _catalog;

        private ItemBuyer _buyer;
        private Wallet _wallet;

        public override void InstallBindings()
        {
            Container.Bind<ItemCatalog>().FromInstance(_catalog);
            Container.Bind<ItemBuyer>().AsSingle().NonLazy();
            Container.Bind<Wallet>().AsSingle().NonLazy();
        }
    }
}
