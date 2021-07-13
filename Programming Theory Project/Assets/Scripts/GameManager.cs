using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Vehicle vehicle;
    private Car car;
    private Plane plane;
    private Boat boat;

    // Start is called before the first frame update
    void Start()
    {
        vehicle = new Vehicle
        {
            year = 1995,
            color = "Red",
            brand = "Ford"
        };

        car = new Car
        {
            year = 1997,
            color = "Yellow",
            brand = "Chevrolet"
        };

        plane = new Plane
        {
            year = 2018,
            color = "Gray",
            brand = "Boeing 737"
        };

        boat = new Boat
        {
            year = 2015,
            color = "White",
            brand = "Bennington"
        };

        vehicle.Move(new Vector2(0, 0));
        vehicle.TurnOn();
        vehicle.TurnOff();

        car.Move(new Vector2(0, 0));
        car.TurnOn();
        car.TurnOff();

        plane.Move(new Vector3(0, 0, 0));
        plane.TurnOn();
        plane.TurnOff();

        boat.Move(new Vector2(0, 0));
        boat.TurnOn();
        boat.TurnOff();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
