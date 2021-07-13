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
        vehicle = gameObject.AddComponent<Vehicle>();
        vehicle.year = 1995;
        vehicle.color = "Red";
        vehicle.brand = "Ford";

        car = gameObject.AddComponent<Car>();
        car.year = 1997;
        car.color = "Yellow";
        car.brand = "Chevrolet";

        plane = gameObject.AddComponent<Plane>();
        plane.year = 2018;
        plane.color = "Gray";
        plane.brand = "Boeing 737";

        boat = gameObject.AddComponent<Boat>();
        boat.year = 2015;
        boat.color = "White";
        boat.brand = "Bennington";

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

}
