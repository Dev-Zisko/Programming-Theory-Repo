using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Class Child (INHERIT)
public class Plane : Vehicle
{
    // Method Changed (POLYMORPHISM)
    public new void Move(Vector3 position)
    {
        Debug.Log("I am a plane, I can move in 3 directions and can't move in reverse.");
    }

    // Method Override (POLYMORPHISM)
    public override void TurnOn() // can override virtual methods from parent class
    {
        Debug.Log("I am a plane. My color is: " + _color + " and my brand is: " + _brand + ".");
    }

    // Method Override (POLYMORPHISM)
    public override void TurnOff()
    {
        Debug.Log("Plane off.");
    }
}
