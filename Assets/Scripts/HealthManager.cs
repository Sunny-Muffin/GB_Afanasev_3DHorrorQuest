using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManager : MonoBehaviour
{
    [SerializeField] private float maxHealth;
    [SerializeField] private float curHealth;
    [SerializeField] private float deathTime;

    [SerializeField] private GameObject explosionPrefab;
    [SerializeField] private Slider slider;

    private void Awake()
    {
        curHealth = maxHealth;
        if (slider)
        {
            slider.maxValue = maxHealth;
            slider.value = curHealth;
        }
    }

    public void Hit(float damage)
    {
        curHealth -= damage;
        if (slider)
        {
            slider.value = curHealth;
        }
        if (curHealth <= 0)
        {
            curHealth = 0;
            // make coroutine
            Death();
        }
    }

    private void Death()
    {
        // sound
        // animation
        // wait
        if (gameObject.tag == "Player")
        {
            Time.timeScale = 0;
            // death menu
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void AddHealth(float plusHP)
    {
        curHealth += plusHP;
        if (slider)
        {
            slider.value = curHealth;
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Hit(10);
        }
        if (Input.GetButtonDown("Fire2"))
        {
            AddHealth(10);
        }
    }
}