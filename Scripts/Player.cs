using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;
    public HealthBar healthBar;

    public int maxO2 = 100;
    public int currentO2;
    public O2Bar o2Bar;

    public float currentTime = 0f;
    public float startingTime = 100f;

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);

        currentO2 = maxO2;
        o2Bar.SetMaxO2(maxO2);

        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;

        /*if (currentTime == 90f)
        {
            TakeDamageO2(10);
        }*/

    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy")
        {
            TakeDamage(1);
        }
    }


    void TakeDamage (int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }

    void TakeDamageO2 (int damageO2)
    {
        currentO2 -= damageO2;
        o2Bar.SetO2(currentO2);
    }
}
