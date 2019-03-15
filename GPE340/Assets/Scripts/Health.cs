using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Health : MonoBehaviour
{

    [Header("Health")]
    private float health;
    public float maxHealth;
    public Text healthText;

    // Use this for initialization
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        //calls function
        displayHealth();
    }

    // sets health text to health variable
    public void displayHealth()
    {
        healthText.text = health + "" ;
    }
    //block for taking damage
    public void TakeDamage(float amount)
    {
        health -= amount;
    }
    //increase health 
    public void Heal(float amount)
    {
        health += amount;
    }

}