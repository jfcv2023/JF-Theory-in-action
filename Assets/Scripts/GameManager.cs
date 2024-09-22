using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        // Creating objects using Inheritance
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        // Polymorphism in action - calling overridden methods
        myDog.MakeSound(); // Output: The dog barks: Woof!
        myCat.MakeSound(); // Output: The cat meows: Meow!

        myDog.Move(); // Output: The dog runs quickly!
        myCat.Move(); // Output: The cat walks gracefully.

        // Encapsulation - interacting with health
        myDog.TakeDamage(20); // Reduces health of the dog by 20
        myCat.TakeDamage(50); // Reduces health of the cat by 50
    }
}
