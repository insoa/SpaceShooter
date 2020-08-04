using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
    public float xMin, xMax, zMin, zMax;
}

public class PlayerController : MonoBehaviour
{
    [SerializeField] private SpaceshipData _spaceshipData;
    public Boundary boundary;
    public bl_Joystick Joystick;

    public void Start()
    {
        StartCoroutine(FequencySpawn());
    }

    public void FixedUpdate()
    {
        float moveVertical = Input.GetAxis("Vertical");
        float noveHorizontal = Input.GetAxis("Horizontal");

        // Управление джостиком для android и управление клавишами для editor
#if UNITY_EDITOR
        GetComponent<Rigidbody>().velocity = new Vector3(noveHorizontal, 0, moveVertical) * _spaceshipData.SpaseshipSpeedPc * Time.deltaTime;

#elif UNITY_ANDROID
        GetComponent<Rigidbody>().velocity = new Vector3(noveHorizontal = Joystick.Horizontal, 0 , moveVertical = Joystick.Vertical) * _spaceshipData.SpaceshipSpeed * Time.deltaTime;
#endif
        //Ограничение движения за рамики игровой области
        GetComponent<Rigidbody>().position = new Vector3
         (Mathf.Clamp(GetComponent<Rigidbody>().position.x, boundary.xMin, boundary.xMax), 0.0f, Mathf.Clamp(GetComponent<Rigidbody>().position.z, boundary.zMin, boundary.zMax));
    }

    [SerializeField] private GameObject _bulletPref;
    [SerializeField] private Transform _laserGunPosition;
    private GameObject _newBullet;


    [SerializeField] private AudioSource _shot;
    //Спавн снарядов
    private void Shooting()
    {
        _newBullet = Instantiate(_bulletPref.gameObject, _laserGunPosition);
        _shot.Play();
    }

    //Частота стрельбы
    IEnumerator FequencySpawn()
    {
        while (true)
        {
            Shooting();
            yield return new WaitForSeconds(0.3f);
        }
    }

    //Списание здоровья при столкновении и уничтожение
    UiControll SpaceshipHealth = new UiControll();

    private void OnTriggerEnter(Collider asteroid)
    {
        if (asteroid.tag == "Asteroid")
        {
            SpaceshipHealth.Health -= 1;
            
            if (SpaceshipHealth.Health == 0)
            {               
                Destroy(this.gameObject);
            }
        }
    }

}
