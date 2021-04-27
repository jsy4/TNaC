using System.Collections;
using System.Collections.Generic;
using System.IO; //work with files
using UnityEngine;
using UnityEngine.SceneManagement;
using System.Runtime.Serialization.Formatters.Binary;
using System;

[Serializable] 
public class Player :MonoBehaviour
{
    //instantiate Lv and Hp  
    private int Lv = 1; 
    private int Hp = 10;
    private int weapon;
    public Player(int v, int h, int w) {Lv = v;Hp = h;weapon = w; }
    public int getLv() { return Lv; }
    public int getHp() { return Hp;  }
    public int getWeapon() { return weapon; }
    public void setLv(int v) { Lv = v; }
    public void setHp(int h) { Hp = h; }
    public void setWeapon(int w) { weapon = w; }

    /** function: <Lv = Lv +1> */
    public void ChangeLv() 
    {
        Debug.Log("Change Lv call with prev " + Lv);
        if(Lv < 4)
            Lv++;
    }

    
    /** function: <Hp = Hp - health> 
     *          given different health for different enemy obj*/
    public void changeHp(int health) 
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

    public void savePlayerData(Player player)
    {
        Debug.Log("Save Data called");
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + Path.DirectorySeparatorChar + "player.txt";

        //if no file exist on the path create one
        if (!File.Exists(path))
        { File.Create("player.txt"); Debug.Log("File Created"); }

        Debug.Log("opening and saving to a file...");
        FileStream stream = new FileStream(path, FileMode.Create);
        formatter.Serialize(stream, player);
        stream.Close();  stream.Dispose();
    }//savePlayerData
    
    public void loadPlayerData()
    {
        Debug.Log("Load Data called");
        string path = Application.persistentDataPath + Path.DirectorySeparatorChar + "player.txt";
        try// (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            Player player = formatter.Deserialize(stream) as Player; 
            stream.Close(); stream.Dispose();
            //return p;

        }
        catch
        {
            Debug.LogError("File to Load Not Found at " + path);
            Player player = gameObject.AddComponent<Player>();
            player.setHp(10);
            player.setLv(1);
            player.setWeapon(0);
            loadPlayerData();
            //return p;

        }

    }//loadPlayerData

    //from : https://youtu.be/XOjd_qU2Ido 
    //helped by : https://stackoverflow.com/questions/55268664/serializeexception-attempting-to-deserialize-an-empty-stream-error
    // for persistant path read : https://docs.unity3d.com/ScriptReference/Application-persistentDataPath.html

}//Player

 