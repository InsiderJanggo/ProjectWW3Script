using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    [Header("To Input What Is The Crouch Key")]
    public KeyCode crouchKey;

    //private variables
    private CharacterController character;
    public bool isCrouching = false;
    private float originalHeight;
    private float normalSpeed;
    [SerializeField] private float crouchHeight = 0.5f;
    [SerializeField] private float crouchSpeed = 3f;
    private void Start()
    {
        character = GetComponent<CharacterController>();
        originalHeight = character.height;
        normalSpeed = crouchSpeed;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(crouchKey))
        {
            isCrouching = !isCrouching;

            CheckCrouch();
        }
    }

    void CheckCrouch()
    {
        if (isCrouching == true)
        {
            character.height = crouchHeight;
            normalSpeed = crouchSpeed;
        }
        else 
        {
            character.height = originalHeight;
        }
    }
}
