using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private GameObject bulletPrefab;
    private float minX, maxX;

    private void Start()
    {
        CalculateScreenBounds();
    }

    private void Update()
    {
        MovePlayer();
        if (Input.GetKeyDown(KeyCode.Space)) Shoot();
    }

    private void CalculateScreenBounds()
    {
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        float playerWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2;
        minX = -screenBounds.x + playerWidth;
        maxX = screenBounds.x - playerWidth;
    }

    private void MovePlayer()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector3 newPos = transform.position + Vector3.right * moveInput * speed * Time.deltaTime;
        newPos.x = Mathf.Clamp(newPos.x, minX, maxX);
        transform.position = newPos;
    }

    private void Shoot()
    {
        Instantiate(bulletPrefab, bulletSpawnPoint.position, Quaternion.identity);
    }
}