using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : Vehicle
{
    public new void Move(Vector3 position)
    {
        Debug.Log("I am a plane, I can move in 3 directions and can't move in reverse.");
    }

    public override void TurnOn() // can override virtual methods from parent class
    {
        Debug.Log("I am a plane. My color is: " + _color + " and my brand is: " + _brand + ".");
    }

    public override void TurnOff()
    {
        Debug.Log("Plane off.");
    }
}
