using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RingGeneration : MonoBehaviour {

    public GameObject Player;
    public GameObject RingPrefab;
    public int ringGap;
    private float x;
    private float z;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //Create point to the next ring
	}

    public void GenerateRings(){
        x = 1250;
        z = 1250;
        for (int y = 2900; y >= 600; y -= ringGap){
            x += Random.Range(-150, 150);
            if(x<50){
                x = 50;
                x += Random.Range(100, 200);
            }else if(x>2450){
                x = 2450;
                x += Random.Range(-200, -100);
            }

            z += Random.Range(-150, 150);
            if(z<50){
                z = 50;
                x += Random.Range(100, 200);
            }else if(z>2450){
                z = 2450;
                z += Random.Range(-200, -100);
            }

            Instantiate(RingPrefab, new Vector3(x, y, z), Quaternion.identity, transform);
        }
    }

    public void ClearRings(){
        GameObject[] Rings = GameObject.FindGameObjectsWithTag("Ring");
        foreach (GameObject Ring in Rings){
            Destroy(Ring);
        }
    }
}
