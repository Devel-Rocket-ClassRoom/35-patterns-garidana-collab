using System;
using System.Collections.Generic;
using System.Text;

class Item
{
    public string Name;
    public string Rarity;
}

class Weapon : Item
{
    public int Damage;
    public string WeaponType;
}

class Armor : Item
{
    public int Defense;
    public string Armortype;
}

class Consumable : Item
{
    public string Effect;
    public int Duration;
}