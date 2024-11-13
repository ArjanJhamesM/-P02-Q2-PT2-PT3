using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHit
{
    void Hit(int hitValueToArcher, int hitValueToSwordsman, int hitValueToGoblin, int hitValueToMercenary);
}

public class ThirdInstruction : MonoBehaviour, IHit
{
    Archer archer;
    Swordsman swordsman;
    Goblin goblin;
    Mercenary mercenary;

    private void Start()
    {
        archer = new Archer();
        swordsman = new Swordsman();
        goblin = new Goblin();
        mercenary = new Mercenary();

        Hit(15, 20, 10, 5);
    }

    public void Hit(int hitValueToArcher, int hitValueToSwordsman, int hitValueToGoblin, int hitValueToMercenary)
    {
        print("Archer's Health before being hit: " + archer.publicHealth);
        archer.publicHealth -= hitValueToArcher;
        print("Archer's Health after being hit: " + archer.publicHealth);

        print("Swordsman's Health before being hit: " + swordsman.publicHealth);
        swordsman.publicHealth -= hitValueToArcher;
        print("Swordsman's Health after being hit: " + swordsman.publicHealth);

        print("Goblin's Health before being hit: " + goblin.publicHealth);
        goblin.publicHealth -= hitValueToGoblin;
        print("Goblin's Health after being hit: " + goblin.publicHealth);

        print("Mercenary's Health before being hit: " + mercenary.publicHealth);
        mercenary.publicHealth -= hitValueToMercenary;
        print("Mercenary's Health after being hit: " + mercenary.publicHealth);
    }
}
