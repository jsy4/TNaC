using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerCollision : MonoBehaviour
{
    static Player player;
    public void Start()
    {
        player = gameObject.AddComponent<Player>();
        player.setHp(10);
        Debug.Log("player HP init in PlayerCollision to 10");
    }
    public void OnCollisionEnter(Collision collision)
    {
        //decrease the Player Hp if collided with the enemy for each level
        if (collision.collider.name == "Enemy1")
        {
            Debug.Log("the player collided the enemy1");
            player.changeHp(1);
        }
        else if (collision.collider.name == "Enemy2")
        {
            Debug.Log("the player collided the enemy2");
            player.changeHp(2);
        }
        else if (collision.collider.name == "Enemy3")
        {
            Debug.Log("the player collided the enemy3");
            player.changeHp(3);
        }
        else if (collision.collider.name == "Enemy4")
        {
            Debug.Log("the player collided the enemy4");
            player.changeHp(4);
        }
        else
        { Debug.Log("the player colided with " + collision.collider.name); }
    }
    //from : https://youtu.be/gAB64vfbrhI

}
