using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public float velocityZ = 10;
    float translationZ;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if(transform.position.z > -7.3)
            {
                return;
            }
            translationZ = Time.deltaTime * velocityZ;
            transform.Translate(0, 0, translationZ);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            if (transform.position.z < -12.7)
            {
                return;
            }
            translationZ = Time.deltaTime * velocityZ;
            transform.Translate(0, 0, -translationZ);
        }
        translationZ = 0;
    
    }
}
