using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RigidBodyCharacterController : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public float jumpForce = 5f;
    Rigidbody rigidbody;
    Vector3 move;
    bool jump = false;

    void Start()
    {

        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");
        move = new Vector3(moveX, 0, moveZ);
        move = move.normalized * moveSpeed;
        move.y = rigidbody.velocity.y;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump = true;
        }


    }
    void FixedUpdate()
    {
        rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationZ;


        rigidbody.velocity = move;
        if (jump)
        {
            rigidbody.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jump = false;
        }



    }
}

