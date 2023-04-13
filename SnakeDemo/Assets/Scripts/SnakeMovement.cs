using System.Collections;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    [SerializeField, Range(.1f, 2f)] float _waitToMove;
    [SerializeField] Transform _snakeTail;

    Vector2 _moveDirectin;

    private void Start()
    {
        _moveDirectin = Vector2.down;
        StartCoroutine(SnakeMove());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && _moveDirectin != Vector2.right)
        {
            _moveDirectin = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D) && _moveDirectin != Vector2.left)
        {
            _moveDirectin = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.W) && _moveDirectin != Vector2.down)
        {
            _moveDirectin = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S) && _moveDirectin != Vector2.up)
        {
            _moveDirectin = Vector2.down;
        }
    }


    IEnumerator SnakeMove()
    {
        while (true)
        {
            yield return new WaitForSeconds(_waitToMove);

            transform.position += (Vector3)_moveDirectin;
        }

    }

}
