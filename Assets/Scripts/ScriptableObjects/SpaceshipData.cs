using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpaceShipData", menuName = "Spaceship", order = 51)]
public class SpaceshipData : ScriptableObject
{
    [SerializeField] private string _spaceshipName;
    [SerializeField] private float _spaceshipSpeed;
    [SerializeField] private GameObject _spaceshipPrefab;
    [SerializeField] private float _spaceshipSpeedForPc;

    public string SpaceshipName
    {
        get { return _spaceshipName; }
    }

    public float SpaceshipSpeed
    {
        get { return _spaceshipSpeed; }
    }

    public GameObject Spaceship
    {
        get { return _spaceshipPrefab; }
    }

    public float SpaseshipSpeedPc
    {
        get { return _spaceshipSpeedForPc; }
    }
}
