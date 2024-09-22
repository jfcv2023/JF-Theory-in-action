using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance: Cat class inherits from Animal
public class Cat : Animal
{
    // Constructor for Cat (calling base constructor)
    public Cat() : base("Cat", 80) { }

    // Polymorphism: Overriding base class method
    public override void MakeSound()
    {
        Debug.Log("The cat meows: Meow!");
    }

    public override void Move()
    {
        Debug.Log("The cat walks gracefully.");
    }
}
