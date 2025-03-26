using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class PlayerModel
{
    public event UnityAction<float> HealthChanged;
    public event UnityAction PlayerDied;

    [SerializeField] private float _maxHealth = 100f;
    private float _currentHealth;

    public void Initialize()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth = Mathf.Clamp(_currentHealth - damage, 0f, _maxHealth);

        HealthChanged?.Invoke(_currentHealth);

        if (_currentHealth <= 0)
            PlayerDied?.Invoke();
    }
}
