using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidController : MonoBehaviour
{
    [SerializeField] AsteroidData _asteroidData;
    [SerializeField] BulletData _bulletData;
    [SerializeField] Transform[] _spawnPoint;

    public void Start()
    {
        StartCoroutine(AsteroidFequencySpawn());
    }

    //Спавн астероидов в радномном порядке в рандомных спавн поинтах
    private void AsteroidSpawn()
    {
        int spawnPointsIndex = Random.Range(0, _spawnPoint.Length);
        int asteroidVariants = Random.Range(0, _asteroidData.Asteroid.Length);
        Instantiate(_asteroidData.Asteroid[asteroidVariants], _spawnPoint[spawnPointsIndex].position, _spawnPoint[spawnPointsIndex].rotation);
    }

    //Частота спавна астероидов
    IEnumerator AsteroidFequencySpawn()
    {
        while (true)
        {
            AsteroidSpawn();
            yield return new WaitForSeconds(1f);
        }
    }
}