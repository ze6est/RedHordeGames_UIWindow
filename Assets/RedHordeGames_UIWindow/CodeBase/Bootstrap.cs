using UnityEngine;

namespace RedHordeGames_UIWindow.CodeBase
{
    public class Bootstrap : MonoBehaviour
    {
        [SerializeField] private ShopWindow _window;

        private void Awake()
        {
            Wallet wallet = new Wallet();
        
            _window.Construct(new ItemBuyer(wallet), wallet);
        }
    }
}
