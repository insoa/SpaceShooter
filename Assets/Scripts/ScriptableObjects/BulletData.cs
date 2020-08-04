using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "Bullets", order = 52)]
public class BulletData : ScriptableObject
{
    [SerializeField] private int _bulletDamage;
    [SerializeField] private float _bulletSpeed;
    [SerializeField] private GameObject _bullet;

    public int BulletDamage
    {
        get { return _bulletDamage; }
    }

    public float BulletSpeed
    {
        get { return _bulletSpeed; }
    }
}