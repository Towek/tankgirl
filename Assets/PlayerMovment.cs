using UnityEngine;
using System.Collections;

public class PlayerMovment : MonoBehaviour
{
    //public
    public Rigidbody rb;
    public float movementSpeed = 5.0f;
    public float mouseSpeed = 2.0f;
    //private
    private Vector3 movement = Vector3.zero;
    private CharacterController cc;

    // Use this for initialization
    void Start()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //mouse rotate
        float mouseRotate = Input.GetAxis("Mouse X") * mouseSpeed;
        transform.Rotate(0, mouseRotate, 0);

        //movement
        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

        Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);
        speed = transform.rotation * speed;
        cc.SimpleMove(speed);
    }
}