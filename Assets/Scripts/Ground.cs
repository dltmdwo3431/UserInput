﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float zRotation = transform.transform.localEulerAngles.z;
        zRotation -= Input.GetAxis("Horizontal");
        transform.localEulerAngles = new Vector3(10, 0, zRotation);

        if (Input.touchCount > 0 || Input.GetMouseButton(0))
        {
            Debug.Log("Mouse Down: " + Input.mousePosition);
            if (Input.mousePosition.x < Screen.width / 2)
            {//왼쪽 클릭
                transform.localEulerAngles = new Vector3(10, 0, transform.localEulerAngles.z + 1);
            }
            else
            {//오른쪽 클릭
                transform.localEulerAngles = new Vector3(10, 0, transform.localEulerAngles.z - 1);
            }
        }
	}
}
