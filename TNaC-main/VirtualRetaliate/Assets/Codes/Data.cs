using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Data {

    public static int Lv;
    public static int Hp;
    public float[] position;

    public Data (Player player) {

        position = new float[3];
        position[0] = player.transform.position.x;
        position[1] = player.transform.position.y;
        position[2] = player.transform.position.z; 
        //could also do same for colors rgb


    }
    //https://youtu.be/XOjd_qU2Ido 

}
