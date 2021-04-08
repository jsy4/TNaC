using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WeaponDisplay : MonoBehaviour
{
    Text Weapon_Text;
    // Start is called before the first frame update
    void Start()
    {
        ReadWriteData.LoadData(); //this loads player data
        Weapon_Text = GetComponent<Text>();
        Weapon_Text.text = "Weapon select: " + Player.getWeapon();
    }

    // Update is called once per frame
    void Update()
    {
        Weapon_Text.text = "Weapon: " + Player.getWeapon();
        Weapon_Text = GetComponent<Text>();

    }
}
