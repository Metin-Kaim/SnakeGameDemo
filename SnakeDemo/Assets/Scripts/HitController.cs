using UnityEngine;

public class HitController : MonoBehaviour
{
    public static event System.Action OnEat;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Food"))
        {
            OnEat?.Invoke();
        }
        else if (collision.CompareTag("Obstacle"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
