using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LvDisplay : MonoBehaviour
{

    Text Lv_text;
    static Player player;

    // Start is called before the first frame update
    void Start()
    { 
        Lv_text = GetComponent<Text>();
        player = gameObject.AddComponent<Player>();
        player.loadPlayerData();
        Debug.Log("player LV init in LvDisplay");
        Lv_text.text = "Level: " + player.getLv();
    }

    // Update is called once per frame
    void Update()
    { 
        Lv_text.text = "Level: " + player.getLv();
        Lv_text = GetComponent<Text>();

    }
}
