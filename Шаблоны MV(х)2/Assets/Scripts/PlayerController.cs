public class PlayerController
{
    private PlayerModel _model;
    private PlayerView _view;

    public PlayerController(PlayerModel model, PlayerView view)
    {
        _model = model;
        _view = view;

        _model.HealthChanged += _view.UpdateHealthDisplay;
        _model.PlayerDied += _view.OnPlayerDeath;
    }

    public void ApplyDamage(float damage)
    {
        _model.TakeDamage(damage);
    }
}