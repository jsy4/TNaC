using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float speed = 6.0f;
    public float jumpSpeed = 8.0f;
    public float gravity = 9.81f;

    // Update is called once per frame
    void Update()
    {
        //from https://www.youtube.com/watch?v=e5g1nJcjz-M
        CharacterController controller = GetComponent<CharacterController>();
        Vector3 moveValues = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(moveValues);

    }
}
