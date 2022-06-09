using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIController : MonoBehaviour
{
    [SerializeField] private Transform[] _waypoints;
    [SerializeField] private Transform _selfTransform;
    [SerializeField] private CarMover _car;

    private int _currentPoint;

    private void Update()
    {
        Transform current = _waypoints[_currentPoint];

        Vector3 direction = _selfTransform.position - current.position;
        float angel = Vector3.Dot(direction, -_selfTransform.right);

        if (angel > 0)
        {
            _car.RotateRight();
        }
        else if (angel == 0)
        {
 
        }
        else
        {
            _car.RotateLeft();
        }

        if (angel < 0.2f && angel > -0.2f)
        {
            _car.Accelerate();
        }

        if (Vector3.Distance(_selfTransform.position, current.position) < 1f)
        {
            _currentPoint++;

            if (_currentPoint > _waypoints.Length)
            {
                _currentPoint = 0;
            }
        }
    }
}