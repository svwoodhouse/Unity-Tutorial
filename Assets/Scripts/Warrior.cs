using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warrior : Player
{
   public Warrior (int health, int power, string name) {
        Health = health;
        Power = power;
        Name = name;
    }

    // Overriding the Attack function from the Player class since the Warrior will be attacking with an axe and not fire
    // You need to have override to override the Attack funstion
    public override void Attack()
    {
        Debug.Log("Warrior is attacking with an AXE.");
    }

} // class
