﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class cameraMove : MonoBehaviour
{
    public Transform target;
    public float dist = 1.0f;
    public float height = 1.0f;
    public float smoothRotate = 5.0f;

    private Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
    }

    void LateUpdate()
    {
        float currYAngle = Mathf.LerpAngle (tr.eulerAngles.y,target.eulerAngles.y,smoothRotate * Time.deltaTime);

        Quaternion rot = Quaternion.Euler(0,currYAngle,0);

        tr.position = target.position - (rot*Vector3.forward * dist)+(Vector3.up*height);

        //tr.LookAt(target);
    }
}