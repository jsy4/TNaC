using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveEnemy : MonoBehaviour
{

    public Transform Player;
    int MoveSpeed = 4;
    int MaxDist = 10;
    int MinDist = 5;
    void Start() { }
    // Update is called once per frame    
    void Update()
    {
        transform.LookAt(Player); //rotates camera so that it looks at the Player obj

        if (Vector3.Distance(transform.position, Player.position) >= MinDist)
        {
            transform.position += transform.forward * MoveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, Player.position) <= MaxDist)
            {
                //Here Call any function U want Like Shoot at here or something
            
            } //https://answers.unity.com/questions/274809/how-to-make-enemy-chase-player-basic-ai.html

        }
    }
}
