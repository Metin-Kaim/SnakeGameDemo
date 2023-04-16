using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    [SerializeField] GameObject _gameOverPanel;

    private void Awake()
    {
        _gameOverPanel.SetActive(false);
    }

    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += GameOverActivater;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= GameOverActivater;
    }

    public void GameOverActivater()
    {
        _gameOverPanel.SetActive(true);
    }//timescale 1

    public void LoadLevel(int level)
    {
        GameManager.Instance.LoadLevelScene(level);
    }
}
