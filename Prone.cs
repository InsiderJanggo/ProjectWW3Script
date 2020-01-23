using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prone : MonoBehaviour
{
    [Header("To Input What Is The Prone Key")]
    public KeyCode proneKey;

    //private variables
    private CharacterController character;
    public bool isProning = false;
    private float originalHeight;
    [SerializeField] private float proneHeight = 0.25f;

    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        originalHeight = character.height;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(proneKey))
        {
            isProning = !isProning;

            CheckProne();
        }
    }

    void CheckProne()
    {
        if (isProning == true)
        {
            character.height = proneHeight;
        }
        else
        {
            character.height = originalHeight;
        }
    }
}
