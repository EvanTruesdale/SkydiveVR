using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingMotion : MonoBehaviour {
    
	// Use this for initialization
	void Start () {
        if (gameObject.transform.position.y >= 2000) {
            GetComponent<Transform>().localScale = new Vector3(1,1,1);
        } else {
            GetComponent<Transform>().localScale  = new Vector3(.1f + (.9f/1400f) * (gameObject.transform.position.y - 600),
                                                                .1f + (.9f/1400f) * (gameObject.transform.position.y - 600),
                                                                .1f + (.9f/1400f) * (gameObject.transform.position.y - 600));
        }



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
