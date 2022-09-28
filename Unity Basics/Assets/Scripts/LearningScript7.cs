using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningScriptƄ : MonoBehaviour
{
// Start is called before the first frame update
void Start()
{
CustomClass cc = new CustomClass();
print("health = " + cc.health);
print("maxHealth = " + cc.maxHealth);
print("CurrentHealthPercent = " +
cc.CurrentHealthPercent() + "%");
}
}
