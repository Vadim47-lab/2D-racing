using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMover : MonoBehaviour
{
    [SerializeField] private Transform _selfTransform;
    [SerializeField] private float _acceleration;
    [SerializeField] private float _turnRight;
    [SerializeField] private float _turnLeft;


    private Vector3 _force;

    private void Update()
    {
        _selfTransform.position += _force;

        if (Input.GetKey(KeyCode.Space))
        {
            _force += (_selfTransform.up * Time.deltaTime) * _acceleration;
        }
        else
        {
            _force = Vector3.Lerp(_force, Vector3.zero, Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
            _selfTransform.Rotate(0, 0, _turnRight);
        }

        if (Input.GetKey(KeyCode.D))
        {
            _selfTransform.Rotate(0, 0, _turnLeft);
        }
    }
}