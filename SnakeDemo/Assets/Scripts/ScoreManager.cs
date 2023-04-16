using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _scoreText;

    int _score = 0;

    private void Awake()
    {
        _scoreText.text = _score.ToString();
    }

    private void OnEnable()
    {
        HitController.OnEat += ScoreIncreaser;
    }
    private void OnDisable()
    {
        HitController.OnEat -= ScoreIncreaser;
    }


    public void ScoreIncreaser()
    {
        _score++;
        _scoreText.text = _score.ToString();
    }
}
