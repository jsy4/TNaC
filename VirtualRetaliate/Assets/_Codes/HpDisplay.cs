using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HpDisplay : MonoBehaviour
{
    //HpDisplay is to be changed graphically to hearts (hopefully)
    Text Hp_text;
    // Start is called before the first frame update
    void Start()
    {
        ReadWriteData.LoadData();
        Hp_text = GetComponent<Text>();
        Hp_text.text = "Health: " + Player.getHp();
    }

    // Update is called once per frame
    void Update()
    {
        //    Debug.Log("Showing LV: " + Player.getLv());
        Hp_text.text = "Health: " + Player.getHp();
        Hp_text = GetComponent<Text>();

    }
}
