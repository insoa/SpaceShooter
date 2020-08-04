using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    [SerializeField] Text _timerText;
    [SerializeField] float _timer;
    [SerializeField] GameObject _spaceship;
    [SerializeField] GameObject _healthPanel;
    [SerializeField] private AudioClip _winClip;
    private AudioSource _winMusic;
    public GameObject WinPanel;
    private bool _runingTimer = true;

    public void Start()
    {
        _winMusic = WinPanel.GetComponent<AudioSource>();
        _timerText.text = _timer.ToString();
    }

    public void Update()
    {
        if (_runingTimer == true)
        {
            _timer -= Time.deltaTime;
            _timerText.text = Math.Round(_timer).ToString();
        }
       
        if (_timer <= 0)
        {
            _runingTimer = false;
            WinPanel.SetActive(true);
            _spaceship.SetActive(false);
            _healthPanel.SetActive(false);           
        }
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Level1()
    {
        SceneManager.LoadScene(1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(2);
    }

    public void Level3()
    {
        SceneManager.LoadScene(3);
    }

    public void Level4()
    {
        SceneManager.LoadScene(4);
    }
}
