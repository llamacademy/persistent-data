using System;
using System.Collections.Generic;

[Serializable]
public class PlayerStats 
{
    public int Health = 100;
    public string Name = "Llama Lover";
    public float BaseAttackSpeed = 1;
    public int Level = 1;
    public bool HasUnlockedSomething;
    public bool HasUnlockedSomethingElse;

    public Dictionary<Slot, Equipment> Equipment = new Dictionary<Slot, Equipment>()
    {
        { Slot.Head, new Armor() {
            Name = "Tiara",
            EquippedSlot = Slot.Head,
            Rarity = Rarity.Common,
            Value = 5,
            Defense = 1
        }},
        { Slot.Chest, new Armor() {
            Name = "Rags",
            EquippedSlot = Slot.Chest,
            Rarity = Rarity.Common,
            Value = 5,
            Defense = 1
        } },
        { Slot.Legs, new Armor() {
            Name = "Rags",
            EquippedSlot = Slot.Legs,
            Rarity = Rarity.Common,
            Value = 5,
            Defense = 1
        } },
        { Slot.Feet, null },
        { Slot.Hands, null },
        { Slot.Neck, null },
        { Slot.Ammo, null },
        { Slot.WeaponLeft, null },
        { Slot.Shield, null },
        { Slot.TwoHandedWeapon, null },
        { Slot.Wrist, null }
    };

    public List<Item> Inventory = new List<Item>() { 
        new Item() { 
            Value = 1, 
            IsConsumable = false, 
            Name = "Gold Pieces", 
            Rarity = Rarity.Common, 
            Quantity = 10 
        } 
    };
}
