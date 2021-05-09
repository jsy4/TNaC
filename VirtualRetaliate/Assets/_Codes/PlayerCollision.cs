using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public static int Hp;
    public static int Lv;
    private void OnCollisionEnter(Collision collision)
    {   //decrease the Player Hp if collided with the enemy for each level
        if (collision.collider.name == "Enemy1")
        {
            Debug.Log("the player collided the enemy1");
            Player.Hp -= 1;
        }
        else if (collision.collider.name == "Enemy2")
        {
            Debug.Log("the player collided the enemy2");
            Player.Hp -= 2;
        }
        else if (collision.collider.name == "Enemy3")
        {
            Debug.Log("the player collided the enemy3");
            Player.Hp -= 3;
        }
        else if (collision.collider.name == "Enemy4")
        {
            Debug.Log("the player collided the enemy4");
            Player.Hp -= 4;
        }
        else
        { Debug.Log("the player colided with " + collision.collider.name); }

        if (Player.Hp <= 0)
        {
            Debug.Log("you died...");
            Player.Hp = 10; //after death, direct to main page and refill health
            SceneManager.LoadScene("Menu");
        }
    }
    //from : https://youtu.be/gAB64vfbrhI

}
