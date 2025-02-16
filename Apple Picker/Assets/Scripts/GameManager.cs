using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public AppleTree appletree;
    public GameObject startButton;
    public Basket basket;

    public static GameManager gameState { get; private set; }

    public enum GameState { MainMenu, Playing, GameOver , Round}
    public GameState CurrentState { get; private set; } = GameState.MainMenu;

    private void Start()
    {
        CurrentState = GameState.MainMenu;
    }

    public void StartTheGame()
    {
        CurrentState = GameState.Playing;
        Debug.Log("Game Started!");
        startButton.SetActive(false);
        appletree.enabled = true;
        basket.enabled = true;
        
    }

    public void GameOver()
    {
        CurrentState = GameState.GameOver;
        Debug.Log("Game Over!");
        // Show game over UI and restart options
    }

}
