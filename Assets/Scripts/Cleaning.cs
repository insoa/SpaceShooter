using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cleaning : MonoBehaviour
{
    //Удаление, прошедших за край игровой области, снарядов и астероидов
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}