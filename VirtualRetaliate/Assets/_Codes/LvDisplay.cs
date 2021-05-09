using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LvDisplay : MonoBehaviour
{

    Text Lv_text;
    // Start is called before the first frame update
    void Start()
    {
        Lv_text = GetComponent<Text>();
        Lv_text.text = "Level: " + Player.getLv();
    }

    // Update is called once per frame
    void Update()
    {
        //    Debug.Log("Showing LV: " + Player.getLv());
        Lv_text.text = "Level: " + Player.getLv();
        Lv_text = GetComponent<Text>();

    }
}
