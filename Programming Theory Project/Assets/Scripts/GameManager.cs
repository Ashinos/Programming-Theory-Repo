using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    Fish[] allFish;


    void Start()
    {
        allFish = FindObjectsOfType<Fish>();

        foreach (Fish fish in allFish)
        {
            fish.Swim();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
