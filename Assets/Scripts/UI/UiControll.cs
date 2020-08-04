using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiControll : MonoBehaviour
{
    public static int health;
    [SerializeField] private GameObject _heart1, _heart2, _heart3, _healthPanel, _gameOver;
    [SerializeField] private AudioClip _loseMusic;
    [SerializeField] private GameObject _losePanel;
    private AudioSource _lose;

    public int Health
    {
        set { health = value; }
        get { return health; }
    }

    private void Start()
    {
        
        health = 3;
        _heart1.SetActive(true);
        _heart2.SetActive(true);
        _heart3.SetActive(true);
        _healthPanel.SetActive(true);
        _gameOver.SetActive(false);
    }

    private void Update()
    {
        switch (health)
        {
            case 3:
                _heart1.SetActive(true);
                _heart2.SetActive(true);
                _heart3.SetActive(true);
                break;

            case 2:
                _heart1.SetActive(true);
                _heart2.SetActive(true);
                _heart3.SetActive(false);
                break;
            case 1:
                _heart1.SetActive(true);
                _heart2.SetActive(false);
                _heart3.SetActive(false);
                break;

            case 0:
                _heart1.SetActive(false);
                _heart2.SetActive(false);
                _heart3.SetActive(false);
                _healthPanel.SetActive(false);
                _gameOver.SetActive(true);
                Time.timeScale = 0;
                break;

        }
    }
}