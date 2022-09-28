using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScript3 : MonoBehaviour
{
    // Start is called before the first frame update
    public int weapon = 0;
    void Start()
    {
        weapon = Random.Range(1,7);  

        switch (weapon)
        {
          case 1:
        print("You found the sword!");
        break;
        case 2:
        print("You found the axe!");
        break;
        case 3:
        print("You found the dagger!");
        break;
        case 4:
        print("You found the bow!");
        break;
        default:
        print("You didn't find anything!");
        break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}