using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    //MoveSpeed and Rotatespeed sets player speed and jump speed.
    public float MoveSpeed = 10f;
    public float RotateSpeed = 75f;
    private float VertInput;
    private float HorInput;
    private Rigidbody Rigbod;
    public float JumpVelocity = 5f;
    private bool IsJumping;
    //Sets how far can the player be from the ground to perform a jump
    public float DistanceToGround = 0.1f;
    public LayerMask GroundLayer;
    private CapsuleCollider Colid;
    //Checks if player is midair
    private bool IsGrounded()
    {
        Vector3 capsuleBottom = new Vector3(Colid.bounds.center.x,
        Colid.bounds.min.y, Colid.bounds.center.z);
        bool grounded = Physics.CheckCapsule(Colid.bounds.center,
        capsuleBottom, DistanceToGround, GroundLayer, QueryTriggerInteraction.Ignore);
        return grounded;
    }
    // Start is called before the first frame update
    void Start()
    {
        Rigbod = GetComponent<Rigidbody>();
        Colid = GetComponent<CapsuleCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        //The program gets information about the player's input through here
        VertInput = Input.GetAxis("Vertical") * MoveSpeed;
        HorInput = Input.GetAxis("Horizontal") * RotateSpeed;
        IsJumping |= Input.GetKeyDown(KeyCode.Space);
    }

    void FixedUpdate()
    {
            
        //Checks if the player is both midair and pressing the jump button
        if (IsGrounded() && IsJumping)
            {
                Rigbod.AddForce(Vector3.up * JumpVelocity, ForceMode.Impulse);
            }
            
        // Collects Keyboard information and connect keyboard input with the rest of the code to rotate, move and make the character jump.
        IsJumping = false;  
        Vector3 rotation = Vector3.up * HorInput;
        Quaternion angleRot = Quaternion.Euler(rotation * Time.fixedDeltaTime);
        Rigbod.MovePosition(this.transform.position + this.transform.forward * VertInput * Time.fixedDeltaTime);    
        Rigbod.MoveRotation(Rigbod.rotation * angleRot);
    }
}