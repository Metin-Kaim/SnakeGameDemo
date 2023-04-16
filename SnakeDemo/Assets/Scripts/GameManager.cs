using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public event System.Action OnGameOver;
    private void OnEnable()
    {
        OnGameOver += TimeStopper;
    }
    private void OnDisable()
    {
        OnGameOver -= TimeStopper;
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
            Destroy(gameObject);
    }

    public void GameOver()
    {
        OnGameOver?.Invoke();
    }

    private void TimeStopper()
    {
        Time.timeScale = 0;
    }

    public void LoadLevelScene(int level)
    {
        StartCoroutine(LoadLevelAsync(level));
    }

    IEnumerator LoadLevelAsync(int level)
    {
        yield return null;
        SceneManager.LoadSceneAsync(level);
        Time.timeScale = 1;
    }


}
