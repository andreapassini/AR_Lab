using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Managers
{
public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState State;

    public static event Action<GameState> OnGameStateChanged; 

    private void Awake()
    {
        // If there is an instance and it's not me, destroy me
        if (Instance != null && Instance != this)
        {
            Destroy(this);
            return;
        }

        Instance = this;
    }

    private void Start()
    {
        UpdateGameState(GameState.StartingMenu);
    }

    public void UpdateGameState(GameState newState)
    {
        switch (newState)
        {
            case GameState.StartingMenu:
                //HandelStartingMenu();
                break;
            case GameState.Level:
                HandleLevel();
                break;
            case GameState.End:
                HandleEnd();
                break;
        }
        
        // Notify when the GameState is changed
        OnGameStateChanged?.Invoke(newState);
    }

    private void HandleEnd()
    {
        throw new NotImplementedException();
    }

    private void HandelStartingMenu()
    {
        // Load the scene
        SceneManager.LoadScene("StartingScene");
    }

    private void HandleLevel()
    {
        // Load the scene
        SceneManager.LoadScene("LevelScene");
    }
}
}

public enum GameState
{
    StartingMenu,
    Level,
    End
}
