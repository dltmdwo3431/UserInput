using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicalOperagtor : MonoBehaviour {

	// Use this for initialization
	void Start () {
        int age = 15;
        if (age < 20 || age >= 65)
        {
            Debug.Log("할인대상입니다.");
        }
        else
        {
            Debug.Log("정상요금입니다");
        }
        if (age >= 30 && age <= 39)
        {
            Debug.Log("30대 입니다.");
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
