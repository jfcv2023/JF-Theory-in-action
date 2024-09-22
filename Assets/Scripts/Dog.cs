using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    public Dog() : base("Dog", 100) { }

    public override string MakeSound()
    {
        return "The dog barks: Woof!";
    }

    public override string Move()
    {
        return "The dog runs quickly!";
    }
}
