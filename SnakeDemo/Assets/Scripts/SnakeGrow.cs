using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeGrow : MonoBehaviour
{
    [SerializeField] Transform _tailPrefab;

    Transform _currentTail;
    List<Transform> _snake = new();

    public List<Transform> Snake => _snake;

    public Transform CurrentTail { get => _currentTail; set => _currentTail = value; }

    private void Start()
    {
        _snake.Add(transform); // snake_head added
    }

    private void OnEnable()
    {
        HitController.OnEat += AddTail;
    }
    private void OnDisable()
    {
        HitController.OnEat -= AddTail;
    }

    private Transform InstantiateTail()
    {
        return Instantiate(_tailPrefab,transform.parent);
    }

    public void AddTail()//yemekten sonra cagir
    {
        _currentTail = InstantiateTail();
        _currentTail.GetComponent<BoxCollider2D>().enabled = false;

        _currentTail.position = _snake[^1].position;
        _snake.Add(_currentTail);
    }

    public void TailsMove()//her hareket oncesinde cagir
    {
        for (int i = _snake.Count - 1; i > 0; i--) // all tails
        {
            _snake[i].position = _snake[i - 1].position;
        }
    }



}
