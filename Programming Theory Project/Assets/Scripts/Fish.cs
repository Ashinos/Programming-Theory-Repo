using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Fish : MonoBehaviour
{
    float speed = 5;
    public float Speed //ENCAPSULATION
    {
        get { return speed; }
        set
        {
            if (value >= 3 && value <= 15)
            {
                speed = value;
            }

            else
            {
                speed = 3;
                Debug.LogError("Minimum speed is 3 and maximum 15! Speed reset to 3");
            }
                
        }
    }
    public abstract void Swim();

    protected Vector3 SetRandomDirection()
    {
        // Generate a random direction
        Vector3 randomDirection = new Vector3(
            Random.Range(-1f, 1f),
            0f,
            Random.Range(-1f, 1f)
        ).normalized;

        return randomDirection;
    }
}
