using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreMgmt : MonoBehaviour
{
    public static int Lv;
    public int Hp;

    Text text;
    // Start is called before the first frame update
    void Start()
    {
        text = GetComponent<Text>();
        text.text = "Level: " + Lv;
    }

    // Update is called once per frame
    void Update()
    {


    }
}
