using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : Vehicle
{
    public virtual void Move(Vector2 position)
    {
        Debug.Log("I am a Car, I can move in X and Z.");
    }

    public override void TurnOn() // can override virtual methods from parent class
    {
        Debug.Log("I am a car. My color is: " + _color + " and my brand is: " + _brand + ".");
    }

    public override void TurnOff()
    {
        Debug.Log("Car off.");
    }
}
