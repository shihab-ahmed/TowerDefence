using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : Singleton<GameManager>
{

    public Waypoints waypoints;
    public Player player;
    public ShopManager shopManager;
    public UIManager uiManager;
    public BuildManager buildManager;
    // Initialization
    private void Start()
    {
        waypoints = FindObjectOfType<Waypoints>();
        if (waypoints == null)
        {
            Debug.LogError("waypoints not found in the scene.");
        }
        if (Player.Instance == null)
        {
            Debug.LogError("Player not found in the scene.");
        }
        shopManager = FindObjectOfType<ShopManager>();
        if (shopManager == null)
        {
            Debug.LogError("ShopManager not found in the scene.");
        }
        uiManager = FindObjectOfType<UIManager>();
        if (uiManager == null)
        {
            Debug.LogError("UIManager not found in the scene.");
        }
        buildManager = FindObjectOfType<BuildManager>();
        if (buildManager == null)
        {
            Debug.LogError("buildManager not found in the scene.");
        }
    }
    protected override void Awake()
    {
        base.Awake(); // Important for Singleton initialization
        
    }

    private void GameOver()
    {
        //Debug.Log("Game Over!");
        //// You can restart the level or load a game over scene
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
