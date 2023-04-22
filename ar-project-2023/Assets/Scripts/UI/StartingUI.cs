using Managers;
using UnityEngine;

namespace UI
{
    public class StartingUI : MonoBehaviour
    {
        public void StartButton()
        {
            Debug.Log("Pressed");
            GameManager.Instance.UpdateGameState(GameState.Level);
        }
    }
}