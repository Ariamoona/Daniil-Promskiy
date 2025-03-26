using UnityEngine;

public class PlayerBootstrapper : MonoBehaviour
{
    [SerializeField] private GameObject _playerPrefab;
    [SerializeField] private Transform _spawnPoint;

   
    private PlayerModel _model;
    private PlayerView _view;
    private PlayerController _playerController;

    private void Start()
    {
       
        _model = new PlayerModel();
        _model.Initialize();

        GameObject playerInstance = Instantiate(_playerPrefab, _spawnPoint.position, Quaternion.identity);
        _view = playerInstance.GetComponent<PlayerView>();

       
        _playerController = new PlayerController(_model, _view);
    }

    public void ApplyDamage(float damage)
    {
        _playerController.ApplyDamage(damage);
    }
}