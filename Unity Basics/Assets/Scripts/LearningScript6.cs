using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScript6 : MonoBehaviour
{
    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        enemies = GameObject.FindGameObjectsWithTag("Enemy");
        for (int i = 0; i < enemies.Length; i++)
        {
        print("Enemy Number: " + i + " is named " + enemies[i].name);
}

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
