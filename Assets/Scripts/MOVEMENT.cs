using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
public class MOVEMENT : MonoBehaviour
{
    public Camera playerCamera;
    public float walkspeed = 6f;
    public float runspeed = 12f;
    public float jumppower = 7f;
    public float gravity = 10f;

    public float lookspeed = 2f;
    public float lookxlimit = 45f;

    Vector
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
