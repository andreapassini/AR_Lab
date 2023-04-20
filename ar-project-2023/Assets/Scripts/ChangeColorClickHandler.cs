using UnityEngine;
using UnityEngine.EventSystems;

namespace DefaultNamespace
{
    public class ChangeColorClickHandler: MonoBehaviour, IPointerClickHandler
    {
        private Renderer _renderer;

        void Start()
        {
            _renderer = transform.GetComponent<Renderer>();
        }
        
        public void OnPointerClick(PointerEventData eventData)
        {
            var color = _renderer.material.color == Color.yellow ? Color.green : Color.yellow;
            _renderer.material.color = color;
        }
    }
}