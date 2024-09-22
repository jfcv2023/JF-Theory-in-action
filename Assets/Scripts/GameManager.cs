using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Threading;

public class GameManager : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI uiTextInfo;
    private float waitTime = 2f;

    private void Start()
    {
        // Start the coroutine to display messages one by one
        StartCoroutine(DisplayMessagesWithDelay());
    }

    // Coroutine to display messages one by one with a delay
    private IEnumerator DisplayMessagesWithDelay()
    {
        // Creating objects using Inheritance
        Animal myDog = new Dog();
        Animal myCat = new Cat();

        // Clear the initial UI text
        uiTextInfo.text = "Welcome to the Animal Simulation!";

        // Show each message with a 2-second delay
        yield return new WaitForSeconds(waitTime);
        ShowMessage(myDog.MakeSound()); // Dog barks

        yield return new WaitForSeconds(waitTime);
        ShowMessage(myCat.MakeSound()); // Cat meows

        yield return new WaitForSeconds(waitTime);
        ShowMessage(myDog.Move()); // Dog moves

        yield return new WaitForSeconds(waitTime);
        ShowMessage(myCat.Move()); // Cat moves

        yield return new WaitForSeconds(waitTime);
        ShowMessage(myDog.TakeDamage(20)); // Dog takes damage

        yield return new WaitForSeconds(waitTime);
        ShowMessage(myCat.TakeDamage(50)); // Cat takes damage

        // Final message after all actions are completed
        yield return new WaitForSeconds(waitTime);
        ShowMessage("(this is the end of the demonstration)");
    }

    // Helper function to update the UI text
    private void ShowMessage(string message)
    {
        uiTextInfo.text += "\n" + message; // Append the new message to the existing text
    }
}

