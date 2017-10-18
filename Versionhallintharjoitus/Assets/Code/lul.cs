using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lul : MonoBehaviour {
    public float speed = 5;
    void Update()
    {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        Move(new Vector3(horizontal,0,vertical));
    }

    void Move(Vector3 Input)
    {
        float speed = 5;
        Vector3 moventVector = Input * speed;
        transform.Translate( moventVector*Time.deltaTime);
    }
}
