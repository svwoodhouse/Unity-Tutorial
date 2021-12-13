using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    // By default the variables are set to private
    int health;
    int _power;
    string _name;

    //Another way of getting private variables is by using accessibility modifiers
    int _health;
    public int Health
    {
        get
        {
            return _health;
        }

        set
        {
            _health = value;
        }
    }

    public int Power
    {
        get
        {
            return _power;
        }

        set
        {
            _power = value;
        }
    }

    public string Name
    {
        get
        {
            return _name;
        }

        set
        {
            _name = value;
        }
    }

    public Player()
    {

    }

    public Player(int health, int power, string name) {
        //Health = health;
        this.health = health;
        Power = power;
        Name = name;
    }

    // To override a function you need to have public virtual voidw
    public virtual void Attack()
    {
        // Generic attack sentence
        Debug.Log(_name + " is attacking with fire");
    }

    public void Info()
    {
        Debug.Log("Health is: " + health);
        Debug.Log("Power is: " + Power);
        Debug.Log("Name is: " + Name);
    }

    //Getters and Setters to get health variable 

    public void setHealth(int health)
    {
        this.health = health;
    }

    public int getHealth()
    {
        return this.health;
    }

} // class
