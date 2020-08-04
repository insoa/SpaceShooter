using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonSound : MonoBehaviour
{
    [SerializeField] private AudioSource _buttonPressSound;

    public void ButtonPress()
    {
        _buttonPressSound.Play();
    }

    
}
