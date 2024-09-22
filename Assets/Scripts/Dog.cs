using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Inheritance: Dog class inherits from Animal
public class Dog : Animal
{
    // Constructor for Dog (calling base constructor)
    public Dog() : base("Dog", 100) { }

    // Polymorphism: Overriding base class method
    public override void MakeSound()
    {
        Debug.Log("The dog barks: Woof!");
    }

    public override void Move()
    {
        Debug.Log("The dog runs quickly!");
    }
}
