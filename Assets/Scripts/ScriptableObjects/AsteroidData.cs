using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "AsteroidData", menuName = "Asteroid", order = 53)]

public class AsteroidData : ScriptableObject
{
    [SerializeField] private string _name;
    [SerializeField] private int _health;
    [SerializeField] private float _speed;
    [SerializeField] private GameObject[] _asteroid;

    public int Health
    {
        get { return _health; }
    }

    public float Speed
    {
        get { return _speed; }
    }

    public GameObject[] Asteroid
    {
        get { return _asteroid; }
    }
}