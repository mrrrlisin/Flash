using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magic : MonoBehaviour 
{
    int goodNumber = 0;
    public float speed = 0.5f;

	void Start ()
	{
        Debug.Log("Пока");
	}
	
	void Update ()
	{
        goodNumber = goodNumber + 1 ;
        Debug.Log(goodNumber);    
        if (Time.time > 2)
        {
            transform.Rotate(-speed, 0, 0);
        }
        else
        {
            transform.Rotate(speed, 0, 0);
        }

	}
}
