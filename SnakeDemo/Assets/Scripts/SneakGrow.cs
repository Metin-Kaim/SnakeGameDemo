using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SneakGrow : MonoBehaviour
{
    List<Transform> _snake = new();

    private void Start()
    {
        _snake.Add(transform); // snake_head added
    }




}
