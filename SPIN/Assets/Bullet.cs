using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed = 8f;

    private void Update()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        
        if (transform.position.y > Camera.main.orthographicSize + 1)
            Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (other.CompareTag("Enemy"))
        {
            Enemy enemy = other.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage();
                Destroy(gameObject);
            }
        }
    }
}