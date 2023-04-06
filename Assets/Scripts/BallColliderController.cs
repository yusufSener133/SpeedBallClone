using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallColliderController : MonoBehaviour
{
    [SerializeField] UIConroller _uiController;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            _uiController.Lose = true;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Point")
        {
            _uiController.Score++;
        }
        if (other.tag == "End")
        {
            _uiController.Win = true;
        }

    }
}
