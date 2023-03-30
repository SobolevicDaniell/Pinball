using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;
using TMPro;
using Unity.UI;
using UnityEngine.SceneManagement;

public class Spawn : MonoBehaviour
{
    [SerializeField] private Transform spawnPoint;
    [SerializeField] private GameObject ball;
    [SerializeField] private int ballsCount = 3;
    [SerializeField] private GameObject _btn;


    private int _count = 0;


    private void Start()
    {
        Instantiate(ball, spawnPoint.transform.position, Quaternion.identity);
        _count++;
        _btn.SetActive(false);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Ball" && _count < ballsCount)
        {
            Instantiate(ball, spawnPoint.transform.position, Quaternion.identity);
            _count++;
            Again();
        }
    }

    private void Again()
    {
        if (_count == ballsCount)
        {
            _btn.SetActive(true);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }
}
