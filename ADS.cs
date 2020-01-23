using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ADS : MonoBehaviour
{
    public Vector3 ads;
    public Vector3 preFire;
    public float aimSpeed;
    public GameObject gun;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(1))
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition, ads, aimSpeed * Time.deltaTime);
        }
        else
        {
            transform.localPosition = Vector3.Slerp(transform.localPosition, preFire, aimSpeed * Time.deltaTime);
        }
    }
}
