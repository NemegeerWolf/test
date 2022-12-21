using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    //private bool runEnabled = true; 
    //private bool strafeEnabled = true;

    [SerializeField]
    public float playerSpeed = 5;
    [SerializeField]
    private CharacterController controller;
    [SerializeField]
    private float gravityValue = -9.81f;

    private Vector3 moveVector;
    private Vector3 lastMove;
    private Vector3 playerVelocity;
    private bool groundedPlayer;

    public float _rotationSpeed = 180;

    void Update()
    {
        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        // rotation
        Vector3 rotation = new Vector3(0, Input.GetAxisRaw("Horizontal") * _rotationSpeed * Time.deltaTime, 0);
        transform.Rotate(rotation);

        // Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        Vector3 move =  Input.GetAxis("Vertical") * transform.forward ;


        
        
        controller.Move(move * Time.deltaTime * playerSpeed);

        if (move != Vector3.zero)
        {
          // gameObject.transform.forward = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

        }

        // Changes the height position of the player..

        if (!controller.isGrounded)
        {

        }
        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }

    //void Update()
    //{
    //    if (cc.isGrounded)
    //    {
    //        verticalVelocity = -gravity * Time.deltaTime;
    //        if (Input.GetKeyDown(KeyCode.Space))
    //        {
    //            verticalVelocity = jumpForce;
    //            Debug.Log("JUMPED!");
    //        }
    //    }
    //    else
    //    {
    //        verticalVelocity -= gravity * Time.deltaTime;
    //        moveVector = lastMove;
    //    }

    //    moveVector = Vector3.zero;
    //    moveVector.x = Input.GetAxis("Horizontal");
    //    moveVector.z = Input.GetAxis("Vertical");

    //    moveVector *= playerSpeed;
    //    moveVector.y = verticalVelocity;
    //    moveVector = transform.TransformDirection(moveVector);
    //    cc.Move(moveVector * Time.deltaTime);
    //    lastMove = moveVector;

    //    /*if (runEnabled) { moveVector.x = Input.GetAxis("Horizontal"); }
    //    else { moveVector.x = 0f; }
    //    if (strafeEnabled) { moveVector.z = Input.GetAxis("Vertical"); }
    //    else { moveVector.z = 0f; }*/
    //}

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody rigidbody = collision.collider.attachedRigidbody;
        Debug.Log(rigidbody.velocity);
        controller.Move(rigidbody.velocity * Time.deltaTime);
        controller.Move((collision.gameObject.transform.position - transform.position) * Time.deltaTime);


    }
    private void OnCollisionStay(Collision collision)
    {
        Rigidbody rigidbody = collision.collider.attachedRigidbody;
        Debug.Log(rigidbody.velocity);
        controller.Move(rigidbody.velocity * 2 *Time.deltaTime);
        
    }

    void OnControllerColliderHit(ControllerColliderHit hit)
    {
       
    }

}
