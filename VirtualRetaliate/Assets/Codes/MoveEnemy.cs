using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/** this script moves enimies toward to Player object */
public class MoveEnemy : MonoBehaviour
{
    
    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 0;
    void Start() { }
    // Update is called once per frame    
    void Update()
    {
        transform.LookAt(Player); //rotates camera so that it looks at the Player obj

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        { //if enemy is far from Player move towards Player
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            //if enemy is close enough to Player, decrese health of the player
            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //from answers.unity : Here Call any function U want Like Shoot at here or something
            
            } //https://answers.unity.com/questions/274809/how-to-make-enemy-chase-player-basic-ai.html

        }
    }
}
