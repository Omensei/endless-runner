using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public static event Action OnGameOver;
    public static event Action OnGameRestart;

    private bool isGameOver = false;

    private void Awake()
    {
        if (Instance != null && Instance !=this)
        {
            Destroy(Instance);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);

    }

    public void TriggerGameOver()
    {

        if (isGameOver)
        {
            return;
        }

        isGameOver = true;
        Debug.Log("Gane over");
        OnGameOver?.Invoke();
        Time.timeScale = 0f;

    }

    public void TriggerGameRestart()
    {
        isGameOver = false;
        Time.timeScale = 1f;
        OnGameRestart?.Invoke();
        Debug.Log("Gane restart");
    }


}
