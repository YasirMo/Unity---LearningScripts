using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScript : MonoBehaviour
{
public float speed = 10.0f;
public bool isGrounded = false;
public int lives = 4;
string playerName = "user";
private string enemyName = "computer";
// Start is called before the first frame update
void Start()
{
print("Lets start Scripting ...");
// or Debug.Log("Let's start Scripting ...");
print("speed =" + speed);
print("isGrounded =" + isGrounded);
print("lives =" + lives);
print("playerName =" + playerName);
print("enemyName =" + enemyName);
}
// Update is called once per frame
void Update()
{
}
}
