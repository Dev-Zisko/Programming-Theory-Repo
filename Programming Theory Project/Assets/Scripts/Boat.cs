using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boat : Vehicle
{
    public virtual void Move(Vector2 position)
    {
        Debug.Log("I am a boat, I can move in X and Z.");
    }

    public override void TurnOn() // can override virtual methods from parent class
    {
        Debug.Log("I am a boat. My color is: " + _color + " and my brand is: " + _brand + ".");
    }

    public override void TurnOff()
    {
        Debug.Log("Boat off.");
    }
}
