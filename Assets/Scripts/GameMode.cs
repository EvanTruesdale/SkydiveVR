using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMode : MonoBehaviour {

    public GameObject DetectionSphere;
    public GameObject RingGroup;

    public GameObject ScoreTextObject;
    public GameObject HeightTextObject;
    public GameObject StartTextObject;
    public GameObject ResetTextObject;

    private string mode;

	// Use this for initialization
	void Start () {
        ResetFall();
	}

    public void Click(){
        if (mode == "start"){
            BeginFall();
        } else if (mode == "end"){
            ResetFall();
        }
    }

    private void ResetFall(){
        mode = "start";

        RingGroup.GetComponent<RingGeneration>().GenerateRings();
        GetComponent<Transform>().position = new Vector3(1250, 3000, 1250);
        GetComponent<ScoreSystem>().score = 0;

        GetComponent<Rigidbody>().isKinematic = true;

        DetectionSphere.GetComponent<Collider>().enabled = true;

        ScoreTextObject.GetComponent<Text>().enabled = false;
        HeightTextObject.GetComponent<Text>().enabled = false;
        StartTextObject.GetComponent<Text>().enabled = true;
        ResetTextObject.GetComponent<Text>().enabled = false;
    }

    private void BeginFall(){
        mode = "falling";

        GetComponent<Rigidbody>().isKinematic = false;

        DetectionSphere.GetComponent<Collider>().enabled = false;

        ScoreTextObject.GetComponent<Text>().enabled = true;
        HeightTextObject.GetComponent<Text>().enabled = true;
        StartTextObject.GetComponent<Text>().enabled = false;
        ResetTextObject.GetComponent<Text>().enabled = false;
    }

    private void OnTriggerEnter(Collider externalCollider)
    {
        if(externalCollider.gameObject.name == "Bottom Plane"){
            mode = "end";

            RingGroup.GetComponent<RingGeneration>().ClearRings();
            GetComponent<Rigidbody>().isKinematic = true;

            DetectionSphere.GetComponent<Collider>().enabled = true;

            ScoreTextObject.GetComponent<Text>().enabled = true;
            HeightTextObject.GetComponent<Text>().enabled = false;
            StartTextObject.GetComponent<Text>().enabled = false;
            ResetTextObject.GetComponent<Text>().enabled = true;
        }
    }
}
