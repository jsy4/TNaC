using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    //instantiate Lv and Hp
    public static int Lv = 1;
    public static int Hp = 10;
    public static int getLv() { return Lv; }
    public static int getHp() { return Hp;  }
    public void SavePlayer()
    {
        ReadWriteData.SaveData(this);
    }

    /** function: <Lv = Lv +1> */
    public void ChangeLv() 
    {
        Debug.Log("Change Lv call with prev " + Lv);
        if(Lv < 4)
            Lv++;
        SavePlayer();
    }

    
    /** function: <Hp = Hp - health> 
     *          given different health for different enemy obj*/
    public void ChangeHp(int health) 
    {
        Debug.Log("Change Hp (" + Hp +") with " + health);
        Hp -= health;
        if (Hp <= 0) 
        {
            Debug.Log("you died...");
            Hp = 10; //after death, direct to main page and refill health
            SceneManager.LoadScene("Menu");
        }
    }

    /** not used, but was in demo in the link below */
    public void LoadPlayer()
    {
        Data data = ReadWriteData.LoadData();

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
        transform.position = position;

    } 
    //https://youtu.be/XOjd_qU2Ido 


}
