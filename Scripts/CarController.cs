using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarController : MonoBehaviour
{
    [SerializeField] private CarMover _car;

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            _car.Accelerate();
        }

        if (Input.GetKey(KeyCode.D))
        {
            _car.RotateRight();
        }

        if (Input.GetKey(KeyCode.A))
        {
            _car.RotateLeft();
        }
    }
}