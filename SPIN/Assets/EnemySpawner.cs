using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private int rows = 3;
    [SerializeField] private int columns = 8;
    [SerializeField] private float spacing = 1.5f;
    [SerializeField] private float moveInterval = 2f;
    [SerializeField] private float stepSize = 0.5f;
    private Vector3 direction = Vector3.right;

    private void Start()
    {
        SpawnEnemies();
        InvokeRepeating(nameof(MoveEnemies), moveInterval, moveInterval);
    }

    private void SpawnEnemies()
    {
        for (int y = 0; y < rows; y++)
        {
            for (int x = 0; x < columns; x++)
            {
                Vector3 pos = new Vector3(x * spacing, y * spacing, 0);
                Instantiate(enemyPrefab, pos, Quaternion.identity, transform);
            }
        }
    }

    private void MoveEnemies()
    {
        transform.position += direction * stepSize;
        if (Mathf.Abs(transform.position.x) >= Camera.main.orthographicSize)
            direction *= -1;
    }
}