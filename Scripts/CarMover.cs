using System.Collections;
using System.Collections.Generic;
using UnityEngine.Tilemaps;
using UnityEngine;

public class CarMover : MonoBehaviour
{
    [SerializeField] private Transform _selfTransform;
    [SerializeField] private TileBase _groundTile;
    [SerializeField] private Tilemap _map;
    [SerializeField] private float _acceleration;
    [SerializeField] private float _turnRight;
    [SerializeField] private float _turnLeft;

    public float Speed;

    private Vector3 _force;
    private bool _isAccelerated;

    public float GetForce()
    {
        return _force.magnitude;
    }

    public void Accelerate()
    {
        _force += (_selfTransform.up * Time.deltaTime) * _acceleration;
        _isAccelerated = true;
    }

    public void RotateRight()
    {
        _selfTransform.Rotate(0, 0, _turnRight);
    }
        
    public void RotateLeft()
    {
        _selfTransform.Rotate(0, 0, _turnLeft);
    }

    private void LateUpdate()
    {
        if (!_isAccelerated)
        {
            _force = Vector3.Lerp(_force, Vector3.zero, Time.deltaTime);
        }
        
        if(_groundTile == _map.GetTile(_map.WorldToCell(_selfTransform.position)))
        {
            _force *= 0.9f;
        }
        
        _selfTransform.position += _force * Speed * Time.deltaTime;

        _isAccelerated = false;
    }
}