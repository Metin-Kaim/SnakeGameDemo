using System.Collections;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    [SerializeField, Range(.1f, 2f)] float _waitToMove;
    [SerializeField] Transform _snakeTail;

    Vector2 _moveDirection;
    Vector2 _tempDirection;
    SnakeGrow _snakeGrow;

    private void Awake()
    {
        _snakeGrow = GetComponent<SnakeGrow>();
    }

    private void Start()
    {
        _tempDirection = Vector2.down;
        StartCoroutine(SnakeMove());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A) && _moveDirection != Vector2.right)
        {
            _tempDirection = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.D) && _moveDirection != Vector2.left)
        {
            _tempDirection = Vector2.right;
        }
        else if (Input.GetKeyDown(KeyCode.W) && _moveDirection != Vector2.down)
        {
            _tempDirection = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.S) && _moveDirection != Vector2.up)
        {
            _tempDirection = Vector2.down;
        }
    }


    IEnumerator SnakeMove()
    {
        while (true)
        {
            yield return new WaitForSeconds(_waitToMove);
            _moveDirection = _tempDirection;

            _snakeGrow.TailsMove();

            transform.position += (Vector3)_moveDirection;
        }

    }

}
