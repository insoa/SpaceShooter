using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class AsteroidMovement : MonoBehaviour
{
    [SerializeField] private AsteroidData _asteroidData;
    [SerializeField] private BulletData _bulletData;
    [SerializeField] private Rigidbody _rb;
  
    //Вращение астероидов
    private void Rotation()
    {
        Quaternion rotationY = Quaternion.AngleAxis(1, Vector3.up);
        Quaternion rotationX = Quaternion.AngleAxis(1, Vector3.right);
        transform.rotation *= rotationY * rotationX;
    }

    //Движение по заданной траектории
    private void FixedUpdate()
    {
        Rotation();
        _rb.transform.position -= Vector3.forward * _asteroidData.Speed * Time.deltaTime;
    }

    private int _asteroidHealth;
    private int _bulletDamage;

    public int RealAsteroidHealth
    {
        get { return _asteroidHealth; }
    }

    private void Start()
    {
        _asteroidHealth = _asteroidData.Health;
        _bulletDamage = _bulletData.BulletDamage;
    }

    
    // Списание здоровья при попадание снарядом и уничтожение 
    public void OnTriggerEnter(Collider other)
    {
        _asteroidHealth -= _bulletDamage;
        if (other.tag == "Bullet")
        {
            Destroy(other.gameObject);
        }
        
        if (_asteroidHealth <= 0 || other.tag == "Spaceship")
        {
            Destroy(this.gameObject);
        }
    }
}
