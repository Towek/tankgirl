using UnityEngine;
using System.Collections;

public class PlayerMovment : MonoBehaviour
{
    public Rigidbody rb;
    private Vector3 movement = Vector3.zero;
    public float speed;
    private CharacterController controller;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        CharacterController controller = GetComponent<CharacterController>();
        movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        movement *= speed;
        controller.Move(movement * Time.deltaTime);
    }
}