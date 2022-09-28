using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScript4 : MonoBehaviour
{
public int weapon = 0;
public string weaponName;
public int enemyDistance = 0;
// Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
    if (Input.GetKeyUp("space"))
    {
    WeaponSearch();
    if (weapon < 5)
    {
    DisplayMessage(weaponName);
    }
    }
    }
    void WeaponSearch()
    {
    weapon = Random.Range(1, 7);
    switch (weapon)
    {
    case 1:
    weaponName = "sword";
    break;
    case 2:
    weaponName = "axe";
    break;
    case 3:
    weaponName = "dagger";
    break;
    case 4:
    weaponName = "bow";
    break;
    default:
    print("You didn't find anything!");
    break;
    }
    }
    void DisplayMessage(string name)
    {
    print("You found the " + name + "!");
    }
    }
