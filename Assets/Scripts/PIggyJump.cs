using UnityEngine;
using System.Collections;

public class PIggyJump : MonoBehaviour
{

    public float jumpSpeed = 10f;
    private Rigidbody2D rigi1;
    private Collision2D coll;

    private void Awake()
    {
        rigi1 = GetComponent<Rigidbody2D>();
    }

    //Used for checking if the player is touching the ground 
    void OnCollisionStay2D(Collision2D coll) // C#, type first, name in second
    {
        if (Input.GetKey(KeyCode.Space) /*&& coll.gameObject.tag == "Ground"*/)
        {
            //Jump Script
            rigi1.AddForce(Vector2.up * jumpSpeed, ForceMode2D.Impulse);

        }
    }
}