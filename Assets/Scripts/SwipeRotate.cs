using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeRotate : MonoBehaviour
{
    public Transform _target;

    private float _rotationAngle = 30f; // Angle to rotate per swipe
    private float _rotationSpeed = 100f; // Speed for smooth rotation
    private Quaternion _targetRotation;

    

    protected virtual void Start()
    {
        // Ensure target is set
        if (_target == null)
        {
            Debug.LogError("Target Transform is not set.");
        }
        else
        {
            _targetRotation = _target.rotation;
        }
    }

    private void Update()
    {
        if (_target != null)
        {
            // Smoothly interpolate to the target rotation
            _target.rotation = Quaternion.Lerp(_target.rotation, _targetRotation, Time.deltaTime * _rotationSpeed);
        }
    }

    // Rotate the object left
    public void RotateLeft()
    {
        if (_target != null)
        {
            _targetRotation *= Quaternion.Euler(0, -_rotationAngle, 0);
        }
    }

    // Rotate the object right
    public void RotateRight()
    {
        if (_target != null)
        {
            _targetRotation *= Quaternion.Euler(0, _rotationAngle, 0);
        }
    }

}
