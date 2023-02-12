using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(DestroyBullet))]
public class Bullet : MonoBehaviour, IDamageable, IMovmentable
{
    [SerializeField] private float bulletSpeed;
    [SerializeField] private int damageToDeal = 10;
    
    private Rigidbody _rigidbody;
    private DestroyBullet _destroyBullet;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Start()
    {
        _destroyBullet = GetComponent<DestroyBullet>();
        _destroyBullet.DestroyObjectByTime();
    }

    private void Update()
    {
        Movement(null,bulletSpeed);
    }

    public int DealDamage()
    {
        return damageToDeal;
    }

    public void Init(Vector3 pos, Quaternion rot)
    {
        _rigidbody.velocity = Vector3.zero;
        transform.position = pos;
        transform.rotation = rot;
        gameObject.SetActive(true);
    }
    
    public void Movement(PlayerInputs playerInputs, float speed)
    {
        _rigidbody.AddForce(transform.forward * speed);
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Floor"))
        {
            _destroyBullet.DestroyObject();
        }
    }
}
