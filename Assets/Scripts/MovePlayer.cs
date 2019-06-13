using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public GameObject MainCamera;
    private Transform CameraTransform;
    private Vector3 velocity;
    public float maxSpeed;

	// Use this for initialization
	void Start () {
        CameraTransform = MainCamera.GetComponent<Transform>();
	}

    void FixedUpdate()
    {
        int score = GetComponent<ScoreSystem>().score;

        gameObject.GetComponent<Rigidbody>().drag = Mathf.Pow(.5f, score) + .4f;

        CameraTransform = MainCamera.GetComponent<Transform>();
        maxSpeed = 5 * score + 60;

        velocity = new Vector3(maxSpeed * CameraTransform.forward.x, 
                               GetComponent<Rigidbody>().velocity.y, 
                               maxSpeed * CameraTransform.forward.z);
        
        GetComponent<Rigidbody>().velocity = velocity;
    }
}
