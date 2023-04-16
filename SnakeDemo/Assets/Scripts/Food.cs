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
    private void OnEnable()
    {
        HitController.OnEat += FoodReposition;
    }
    private void OnDisable()
    {
        HitController.OnEat -= FoodReposition;
    }

    public void FoodReposition()
    {
        _currentFood.transform.position = RandomVectorTwo();
    }

    private GameObject FoodInstantiate()
    {
        return Instantiate(_foodPrefab, RandomVectorTwo(), Quaternion.identity);
    }

    private Vector2 RandomVectorTwo(int x = 10, int y = 20)
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
