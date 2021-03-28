using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapons
{
    public enum ItemType
    {
        weapon1,
        weapon2,
        weapon3
    }

    public ItemType itemType;
    public int itemSize;
}

public class Weaponary
{
    private List<Weapons> itemList;
    public Weaponary()
    {
        itemList = new List<Weapons>();
        Debug.Log("Weaponary");
    }
}