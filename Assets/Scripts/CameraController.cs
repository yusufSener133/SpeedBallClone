using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] Transform _ball;
    [SerializeField] Vector3 _offset;


    void LateUpdate()
    {
        Vector3 targetPosition = _ball.position + _offset;
        transform.position = targetPosition;
    }
}
