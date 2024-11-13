// welcome to a whole day worth of mental breakdown
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public interface IStats
{
    public void ReferenceStats(string nameValue = "", int healthValue = 0, int manaValue = 0, int attackValue = 0, int defenseValue = 0, float speedValue = 0.0f, float luckValue = 0.0f) { }
}

public class Archer // I tried to make this reusable with inheritance, but can't
{
    private string name = "Archer";
    private int health = 100;
    private int mana;
    private int attack;
    private int defense;
    private float speed;
    private float luck;

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

    public float publicSpeed
    {
        get { return speed; }
        set { speed = value; }
    }

    public float publicLuck
    {
        get { return luck; }
        set { luck = value; }
    }
}

public class Swordsman // this is bad reused code
{
    private string name = "Swordsman";
    private int health = 100;
    private int mana;
    private int attack;
    private int defense;
    private float speed;
    private float luck;

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

    public float publicSpeed
    {
        get { return speed; }
        set { speed = value; }
    }

    public float publicLuck
    {
        get { return luck; }
        set { luck = value; }
    }
}

public class FirstInstruction : MonoBehaviour, IStats // MonoBehaviour and other base classes don't mix well, tragic
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
        Archer archer = new Archer();
        Swordsman swordsman = new Swordsman();

        ReferenceFinalStats(archer.publicName, archer.publicHealth, archer.publicMana, archer.publicAttack, archer.publicDefense, archer.publicSpeed, archer.publicLuck);
        ReferenceFinalStats(swordsman.publicName, swordsman.publicHealth, swordsman.publicMana, swordsman.publicAttack, swordsman.publicDefense, swordsman.publicSpeed, swordsman.publicLuck);
    }
}
