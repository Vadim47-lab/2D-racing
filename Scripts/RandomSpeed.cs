using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpeed : MonoBehaviour
{
    [SerializeField] private CarMover _car;

    private void Start()
    {
        _car.Speed = Random.Range(1f, 10f);
    }
}