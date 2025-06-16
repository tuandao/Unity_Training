using UnityEngine;

public class Character
{
    public string name;
    public int maxHP;
    public Weapon weapon;

    public Character()
    {
        name = "Peter Paker";
        maxHP = 100;
    }

    public Character(string name, int maxHP)
    {
        this.name = name;
        this.maxHP = maxHP;
    }

    public Character(string name, int maxHP, Weapon weapon)
    {
        this.name = name;
        this.maxHP = maxHP;
        this.weapon = weapon;
    }

    public virtual void DisplayInfo()
    {
        Debug.LogFormat("My Hero is {0} - HP: {1} - Weapon: {2}", name, maxHP, weapon.damage);
    }
}

public class Monster : Character
{
    public float damage;

    public Monster(string name, int maxHP, float damage) : base(name, maxHP)
    {
        this.name = name;
        this.maxHP = maxHP;
        this.damage = damage;
    }

    public override void DisplayInfo()
    {
        Debug.LogFormat("My Monster is {0} - HP: {1} - Damage: {2}", name, maxHP, damage);
    }

}

public struct Weapon
{
    public string name;
    public int damage;
    public float range;
    public Weapon(string name, int damage, float range)
    {
        this.name = name;
        this.damage = damage;
        this.range = range;
    }

    public void DisplayInfo()
    {
        Debug.LogFormat("My Weapon is {0} - Damage: {1} - Range: {2}", name, damage, range);
    }
}