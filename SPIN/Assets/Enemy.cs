using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private int health = 3;
    [SerializeField] private int scoreValue = 10;

    public void TakeDamage()
    {
        health--;
        if (health <= 0)
        {
            GameManager.Instance.AddScore(scoreValue);
            Destroy(gameObject);
        }
    }
}