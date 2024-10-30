using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    Fish[] allFish;


    void Start()
    {
        FindAllFishAndSwim();

    }

    void FindAllFishAndSwim()
    {
        allFish = FindObjectsOfType<Fish>();

        foreach (Fish fish in allFish)
        {
            fish.Swim();
        }
    }

    public void IncreaseFishSpeed()
    {
        foreach (Fish fish in allFish)
        {
            fish.Speed += 1;
            Debug.Log("Current Speed: " + fish.Speed);
        }
    }

    public void DecreaseFishSpeed()
    {
        foreach (Fish fish in allFish)
        {
            fish.Speed -= 1;
            Debug.Log("Current Speed: " + fish.Speed);
        }
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
