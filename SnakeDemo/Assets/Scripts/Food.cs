using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food : MonoBehaviour
{
    [SerializeField] GameObject _foodPrefab;

    GameObject _currentFood;

    private void Start()
    {
        _currentFood = FoodInstantiate();
    }


    public void FoodReposition(int sizeX = 10, int sizeY = 20)
    {
        //_currentFood.SetActive(false);

        _currentFood.transform.position = RandomVectorTwo(sizeX, sizeY);

        //_currentFood.SetActive(true);

    }

    private GameObject FoodInstantiate(int sizeX = 10, int sizeY = 20)
    {
        return Instantiate(_foodPrefab, RandomVectorTwo(sizeX, sizeY), Quaternion.identity);
    }

    private Vector2 RandomVectorTwo(int x, int y)
    {
        int randomX = Random.Range(0, x);
        int randomY = Random.Range(0, y);

        return new Vector2(randomX, randomY);
    }
    //buraya bak...

}
