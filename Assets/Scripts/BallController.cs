using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField, Range(100, 1000)] float _forwardSpeed = 500f;
    [SerializeField] float _moveSpeed = 0.125f;

    Rigidbody _rigidbody;
    float _horizontal, _vertical;
    void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _vertical = Input.GetAxis("Vertical");

        if (_horizontal < 0)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(-(.5f), transform.position.y, transform.position.z), _moveSpeed);
        }
        else if (_horizontal > 0)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3((.5f), transform.position.y, transform.position.z), _moveSpeed);
        }
    }

    void FixedUpdate()
    {
        _rigidbody.AddForce(Vector3.forward * Time.fixedDeltaTime * _forwardSpeed);
    }
}
