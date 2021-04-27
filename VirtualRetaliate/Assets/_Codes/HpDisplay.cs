using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpDisplay : MonoBehaviour
{
    //HpDisplay is to be changed graphically to hearts (hopefully)
    Text Hp_text; 
    static Player player;

    void Start()
    {
        player = gameObject.AddComponent<Player>();
        player.loadPlayerData();
        Hp_text = GetComponent<Text>(); 
        Hp_text.text = "Health: " + player.getHp();
    }

    // Update is called once per frame
    void Update()
    { 
        //    Debug.Log("Showing LV: " + Player.getLv());
        Hp_text.text = "Health: " + player.getHp();
        Hp_text = GetComponent<Text>();

    }
}
