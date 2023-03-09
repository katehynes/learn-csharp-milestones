using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    public string name;
    public int exp = 0;

    public Character() {
        name = "not assigned";
    }
    public Character(string name, int exp) {
        this.name = name;
        this.exp = exp;
    }
}

public struct Weapon {
    public string name;
    public int damage;

    public Weapon(string name, int damage) {
        this.name = name;
        this.damage = damage;
    }
}

public class Paladin : Character {
    
}

