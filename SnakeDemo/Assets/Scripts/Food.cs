using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] Transform _foodPrefab;

    private void Start()
    {
        RandomSpawner();
    }

    public void RandomSpawner(int sizeX = 10, int sizeY = 20)
    {
        int randomX = Random.Range(0, sizeX);
        int randomY = Random.Range(0, sizeY);
        Instantiate(_foodPrefab, new Vector2(randomX, randomY), Quaternion.identity);

    }

}
