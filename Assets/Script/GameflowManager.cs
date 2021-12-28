using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameflowManager : MonoBehaviour
{

    #region Singleton

    private static GameflowManager _instance = null;

    public static GameflowManager Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = FindObjectOfType<GameflowManager>();

                if (_instance == null)
                {
                    Debug.LogError("Fatal Error: GameFlowManager not Found");
                }
            }

            return _instance;
        }
    }

    #endregion

    [Header("UI")]
    public UIGameOver GameOverUI;

    public bool IsGameOver { get { return isGameOver; } }

    private bool isGameOver = false;

    private void Start()
    {
        isGameOver = false;
    }

    public void GameOver()
    {
        isGameOver = true;
        ScoreManager.Instance.SetHighScore();
        GameOverUI.Show();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
