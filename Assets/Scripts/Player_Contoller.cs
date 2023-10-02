using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Contoller : MonoBehaviour
{
    [SerializeField] private float jump_Height;
    [SerializeField]private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            rb.AddForce(Vector3.up * jump_Height);
        }
    }
}
