using UnityEngine;
using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase.Windows.MainWindow
{
    public class MainWindowView : MonoBehaviour, IWindow
    {
        [SerializeField] private Button _upgradesOpenButton;

        public Button UpgradesOpenButton => _upgradesOpenButton;
        
        public void Show()
        {
            gameObject.SetActive(true);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
        }
    }
}