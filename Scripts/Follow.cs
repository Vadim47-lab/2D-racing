using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform _target, _selfTransform;

    private void LateUpdate()
    {
        _selfTransform.position = _target.position + new Vector3(0, 0, -10);
    }
}