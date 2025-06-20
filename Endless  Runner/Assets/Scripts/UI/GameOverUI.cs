using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    [SerializeField] private GameObject gameOverPanel;

    private void Awake()
    {
        gameOverPanel.SetActive(false);
    }
    private void OnEnable()
    {
        Debug.Log("Enabled!");
        GameManager.OnGameOver += ShowPanel;
        GameManager.OnGameRestart += HidePanel;

    }

    private void OnDisable()
    {
        GameManager.OnGameOver -= ShowPanel;
        GameManager.OnGameRestart -= HidePanel;
    }

    private void ShowPanel()
    {
        Debug.Log("ShowPanel() was called!");
        gameOverPanel.SetActive(true);
    }

    private void HidePanel()
    {
        gameOverPanel.SetActive(false);
    }


}
