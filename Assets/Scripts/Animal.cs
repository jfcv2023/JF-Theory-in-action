using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animal
{
    private string animalName;
    private int health;

    public Animal(string name, int health)
    {
        this.animalName = name;
        this.health = health;
    }

    public string GetName()
    {
        return animalName;
    }

    public int GetHealth()
    {
        return health;
    }

    public string TakeDamage(int damage)
    {
        health -= damage;
        if (health < 0)
            health = 0;
        return animalName + " took " + damage + " damage! Health left: " + health;
    }

    // Polymorphic method
    public virtual string MakeSound()
    {
        return animalName + " makes a sound!";
    }

    public virtual string Move()
    {
        return animalName + " is moving.";
    }
}
