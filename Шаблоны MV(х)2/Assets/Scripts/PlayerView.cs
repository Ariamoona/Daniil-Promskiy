using UnityEngine;
using UnityEngine.UI;

public class PlayerView : MonoBehaviour
{
    [SerializeField] private SpriteRenderer _characterSprite;
    [SerializeField] private Text _healthText;

    public void UpdateHealthDisplay(float currentHealth)
    {
        _healthText.text = $"HP: {currentHealth}";
        _characterSprite.color = Color.Lerp(Color.red, Color.white, currentHealth / 100f);
    }

    public void OnPlayerDeath()
    {
        _characterSprite.color = Color.gray;
        _healthText.text = "DEAD";
    }

    
        
        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Enemy"))
            {
                
                FindObjectOfType<PlayerBootstrapper>().ApplyDamage(10f);
            }
        }
    
}

