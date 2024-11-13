using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Goblin
{
    private string name = "Goblin";
    private int health = 100;
    private int mana;
    private int attack;
    private int defense;

    public string publicName
    {
        get { return name; }
        set { name = value; }
    }

    public int publicHealth
    {
        get { return health; }
        set { health = value; }
    }

    public int publicMana
    {
        get { return mana; }
        set { mana = value; }
    }

    public int publicAttack
    {
        get { return attack; }
        set { attack = value; }
    }

    public int publicDefense
    {
        get { return defense; }
        set { defense = value; }
    }
}

public class Mercenary
{
    private string name = "Mercenary";
    private int health = 100;
    private int mana;
    private int attack;
    private int defense;

    public string publicName
    {
        get { return name; }
        set { name = value; }
    }

    public int publicHealth
    {
        get { return health; }
        set { health = value; }
    }

    public int publicMana
    {
        get { return mana; }
        set { mana = value; }
    }

    public int publicAttack
    {
        get { return attack; }
        set { attack = value; }
    }

    public int publicDefense
    {
        get { return defense; }
        set { defense = value; }
    }
}

public class SecondInstruction : MonoBehaviour, IStats
{
    public void ReferenceStats(string nameValue = "", int healthValue = 0, int manaValue = 0, int attackValue = 0, int defenseValue = 0, float speedValue = 0.0f, float luckValue = 0.0f)
    {
        ReferenceFinalStats(nameValue, healthValue, manaValue, attackValue, defenseValue, speedValue, luckValue);
    }

    private void ReferenceFinalStats(string nameValue = "", int healthValue = 0, int manaValue = 0, int attackValue = 0, int defenseValue = 0, float speedValue = 0.0f, float luckValue = 0.0f)
    {
        print(nameValue + "'s health: " + healthValue);
        print(nameValue + "'s mana: " + manaValue);
        print(nameValue + "'s attack: " + attackValue);
        print(nameValue + "'s defense: " + defenseValue);
        print(nameValue + "'s speed: " + speedValue);
        print(nameValue + "'s luck: " + luckValue);
    }

    private void Start()
    {
        Goblin goblin = new Goblin();
        Mercenary mercenary = new Mercenary();

        ReferenceFinalStats(goblin.publicName, goblin.publicHealth, goblin.publicMana, goblin.publicAttack, goblin.publicDefense);
        ReferenceFinalStats(mercenary.publicName, mercenary.publicHealth, mercenary.publicMana, mercenary.publicAttack, mercenary.publicDefense);
    }
}