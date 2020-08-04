using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{
    [SerializeField] private BulletData _bullet;
    [SerializeField] private Rigidbody _rb;

    public void FixedUpdate()
    {
        _rb.transform.position += Vector3.forward * _bullet.BulletSpeed * Time.deltaTime;
    }
}
