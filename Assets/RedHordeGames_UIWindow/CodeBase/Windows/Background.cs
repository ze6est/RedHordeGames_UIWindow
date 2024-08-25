using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;

namespace RedHordeGames_UIWindow.CodeBase.Windows
{
    public class Background : MonoBehaviour, IPointerUpHandler
    {
        public event UnityAction Clicked;
        
        public void OnPointerUp(PointerEventData eventData) => 
            Clicked?.Invoke();
    }
}