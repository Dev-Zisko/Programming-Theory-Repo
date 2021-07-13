using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vehicle : MonoBehaviour
{
    protected int _year;
    protected string _color;
    protected string _brand;

    public int year
    {
        get
        {
            return _year;
        }
        set
        {
            if (value > 0)
            {
                _year = value;
            }
        }
    }

    public string color
    {
        get
        {
            return _color;
        }
        set
        {
            _color = value;
        }
    }

    public string brand
    {
        get
        {
            return _brand;
        }
        set
        {
            _brand = value;
        }
    }

    public void Move(Vector3 position)
    {
        Debug.Log("I am a vehicle, I can move free.");
    }

    public virtual void TurnOn()
    {
        Debug.Log("I am a vehicle. My color is: " + _color + " and my brand is: " + _brand + ".");
    }

    public virtual void TurnOff()
    {
        Debug.Log("Vehicle off.");
    }

}
