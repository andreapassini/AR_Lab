using UnityEngine;

namespace DefaultNamespace
{
    public class TouchObject: MonoBehaviour
    {
        [SerializeField] private AudioClip clipToPlay;
        
        public void OnTouch()
        {
            if (clipToPlay != null)
            {
                AudioManager.Instance.PlayClip(clipToPlay);
            }
        }
    }
}