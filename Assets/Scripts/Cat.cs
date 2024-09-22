using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : Animal
{
    public Cat() : base("Cat", 80) { }

    public override string MakeSound()
    {
        return "The cat meows: Meow!";
    }

    public override string Move()
    {
        return "The cat walks gracefully.";
    }
}
