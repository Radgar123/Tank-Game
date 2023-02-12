using UnityEngine;

[RequireComponent(typeof(PlayerInputs),typeof(PlayerMovement))]
[RequireComponent(typeof(PlayerShoot), typeof(PlayerRotate),
    typeof(CharacterController))]
public class Player : MonoBehaviour
{
    [SerializeField] private PlayerInputs _playerInputs;
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private PlayerRotate _playerRotate;
    [SerializeField] private PlayerShoot _playerShoot;
    [SerializeField] private PlayerHealth _playerHealth;
    
    public GameObject Turret;
    public Transform pointToSpawnAmmoToShot;
    public float movementPlayerSpeed;
    public float rotatePlayerSpeed;
    public float rotateTurretSpeed;

    private void Start()
    {
        _playerInputs = GetComponent<PlayerInputs>();
        _playerMovement = GetComponent<PlayerMovement>();
        _playerRotate = GetComponent<PlayerRotate>();
        _playerShoot = GetComponent<PlayerShoot>();
        _playerHealth = GetComponent<PlayerHealth>();
        
        _playerHealth.SetPlayerHealth();
    }

    private void Update()
    { 
        _playerShoot.Shoot(_playerInputs,0,0,pointToSpawnAmmoToShot);
        _playerHealth.DestroyObject();
    }

    private void FixedUpdate()
    {
        _playerMovement.Movement(_playerInputs,movementPlayerSpeed);
        _playerRotate.FirstRotateOption(_playerInputs, rotatePlayerSpeed);
        _playerRotate.SecondRotateOption(_playerInputs,Turret, rotateTurretSpeed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.root.GetComponent<IDamageable>() != null)
        {
            Debug.Log("GetDamage");
            _playerHealth.ReducePlayerHealth(collision.transform.root.GetComponent<IDamageable>().DealDamage());
        }
        else if(collision.transform.root.GetComponent<IDamageable>() != null && 
                collision.transform.root.GetComponent<IKillable>() != null)
        {
            Debug.Log("test");
        }
    }
}
