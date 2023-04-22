using System;
using UI;
using UnityEngine;

namespace Managers
{
    public class MenuManager : MonoBehaviour
    {
        public StartingUI startingUI;
        
        private void Awake()
        {
            GameManager.OnGameStateChanged += ActivateStartingUI;
        }
        private void OnDestroy()
        {
            GameManager.OnGameStateChanged -= ActivateStartingUI;
        }

        private void Start()
        {
            startingUI.gameObject.SetActive(false);
        }

        private void ActivateStartingUI(GameState startingMenuState)
        {
            startingUI.gameObject.SetActive(startingMenuState == GameState.StartingMenu);
        }

    }
}
