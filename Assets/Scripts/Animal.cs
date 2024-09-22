using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal : MonoBehaviour
{
    // Encapsulated fields (Encapsulation)
    private string animalName;
    private int health;

    // Constructor to set basic properties (Abstraction)
    public Animal(string name, int health)
    {
        this.animalName = name;
        this.health = health;
    }

    // Encapsulation: Getters and setters for protected fields
    public string GetName()
    {
        return animalName;
    }

    public int GetHealth()
    {
        return health;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
            health = 0;
        Debug.Log(animalName + " took " + damage + " damage! Health left: " + health);
    }

    // Abstraction: Common animal behavior
    public virtual void MakeSound()
    {
        Debug.Log(animalName + " makes a sound!");
    }

    public virtual void Move()
    {
        Debug.Log(animalName + " is moving.");
    }
}
