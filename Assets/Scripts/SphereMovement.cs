using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    private Rigidbody _rigidBody;
    private Vector3 _movementVector;

    // Start is called before the first frame update
    void Start()
    {
        _rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        _movementVector.x = Input.GetAxis("Horizontal");
        _movementVector.z = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity += _movementVector;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Coin"))
        {
            Destroy(collision.gameObject);
        }
    }    
}
