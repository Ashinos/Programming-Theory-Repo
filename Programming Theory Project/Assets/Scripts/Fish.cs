using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public abstract class Fish : MonoBehaviour
{
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
