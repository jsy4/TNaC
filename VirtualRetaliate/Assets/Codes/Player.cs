using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Lv;
    public int Hp;
    public void SavePlayer()
    {
        ReadWriteData.SaveData(this);
    }

    public void ChangeLv(int amount) 
    {
        Lv += amount; 
    }

    public void LoadPlayer()
    {
        Data data = ReadWriteData.LoadData();
        Lv = data.Lv;
        Hp = data.Hp;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

    } 
    //https://youtu.be/XOjd_qU2Ido 


}
