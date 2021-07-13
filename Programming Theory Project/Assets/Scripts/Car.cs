using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class Child (INHERIT)
public class Car : Vehicle
{
    // Method Changed (POLYMORPHISM)
    public virtual void Move(Vector2 position)
    {
        Debug.Log("I am a Car, I can move in X and Z.");
    }

    // Method Override (POLYMORPHISM)
    public override void TurnOn() // can override virtual methods from parent class
    {
        Debug.Log("I am a car. My color is: " + _color + " and my brand is: " + _brand + ".");
    }

    // Method Override (POLYMORPHISM)
    public override void TurnOff()
    {
        Debug.Log("Car off.");
    }
}
