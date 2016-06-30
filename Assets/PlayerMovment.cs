using UnityEngine;
using System.Collections;

public class PlayerMovment : MonoBehaviour
{
    //public
    public Rigidbody rb;
    public float movementSpeed = 5.0f;
    public float mouseSpeed = 2.0f;
    public float mouseRange = 60.0f;
    //private
    private Vector3 movement = Vector3.zero;
    private CharacterController cc;
    private float mouseVertical = 0;
    // Use this for initialization
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //mouse rotate
        float mouseHorizontal = Input.GetAxis("Mouse X") * mouseSpeed;
        transform.Rotate(0, mouseHorizontal, 0);

        mouseVertical -= Input.GetAxis("Mouse Y") * mouseSpeed;
        mouseVertical = Mathf.Clamp(mouseVertical, -mouseRange, mouseRange);
        Camera.main.transform.localRotation = Quaternion.Euler(mouseVertical, 0, 0);

        //movement
        float forwardSpeed = Input.GetAxis("Vertical") * movementSpeed;
        float sideSpeed = Input.GetAxis("Horizontal") * movementSpeed;

        Vector3 speed = new Vector3(sideSpeed, 0, forwardSpeed);
        speed = transform.rotation * speed;
        cc.SimpleMove(speed);
    }
}