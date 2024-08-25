using UnityEngine.Events;

namespace RedHordeGames_UIWindow.CodeBase
{
    public class Wallet
    {
        public float Money { get; private set; } = 100;
        public event UnityAction MoneyChanged;

        public void SpendMoney(float itemPrice)
        {
            Money -= itemPrice;
            MoneyChanged?.Invoke();
        }
    }
}