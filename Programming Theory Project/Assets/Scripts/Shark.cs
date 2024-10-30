using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shark : Fish
{
    Rigidbody fishRb;
    Vector3 randomDirection;
    [SerializeField] float speed = 5;
    private void Awake()
    {
        fishRb = GetComponent<Rigidbody>();
        randomDirection = SetRandomDirection();
    }

    public override void Swim()
    {
        fishRb.velocity = randomDirection * speed;
    }

    // Get a new direction on collision and swim
    void OnCollisionEnter(Collision collision)
    {
        randomDirection = SetRandomDirection();
        Swim();
    }

    private void Update()
    {
        /*float currentSpeed = fishRb.velocity.magnitude;
        Debug.Log("Current Speed: " + currentSpeed);*/
    }

    void FixedUpdate()
    {
        // Maintain consistent speed by normalizing the direction and resetting velocity
        if (Mathf.Abs(fishRb.velocity.magnitude - speed) > 0.01f) // Allow small tolerance
        {
            fishRb.velocity = fishRb.velocity.normalized * speed;
        }
    }
}
