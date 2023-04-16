using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.UIElements;

public class Food : MonoBehaviour
{
    [SerializeField] GameObject _foodPrefab;
    [SerializeField] SnakeGrow _snakeGrow;

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
        int randomX, randomY;
        bool isOkey;

        while (true)
        {
            isOkey = true;

            randomX = Random.Range(0, x);
            randomY = Random.Range(0, y);

            foreach (Transform item in _snakeGrow.Snake)
            {
                if (Vector2.Distance(item.position, new Vector2(randomX, randomY)) < .05f)
                {
                    isOkey = false;
                    break;
                }
            }
            if (isOkey)
            {
                return new Vector2(randomX, randomY);
            }
        }

    }
    //buraya bak...

}
