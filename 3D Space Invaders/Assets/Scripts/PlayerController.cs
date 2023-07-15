using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    ///this is the base player controller script
    ///it will allow the player to move left and right
    ///and also fire bullets by pressing the space bar

    public float speed = 5f;
    public float hInput;


    private void Update()
    {
        hInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector3.right * hInput * speed * Time.deltaTime);
    }

    
}
