using UnityEngine;

public class HitController : MonoBehaviour
{
    [SerializeField] Food _foodScript;
    SnakeGrow _sneakGrow;

    private void Awake()
    {
        _sneakGrow= GetComponent<SnakeGrow>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food"))
        {
            _sneakGrow.AddTail();
            _foodScript.FoodReposition();
        }
        else if (collision.CompareTag("Obstacle"))
        {
            print("Dead");
        }
    }
}
