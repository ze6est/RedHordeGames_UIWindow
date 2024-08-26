using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RedHordeGames_UIWindow.CodeBase.Windows.UpgradesWindow
{
    public class UpgradesWindowView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _title;
        [SerializeField] private Button _closeButton;

        public Button CloseButton => _closeButton;
        
        public void SetTitle(string title) => 
            _title.text = title;
    }
}
