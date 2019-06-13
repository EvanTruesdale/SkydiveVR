using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeHeightText : MonoBehaviour {

    public GameObject player;
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "Height: " + Mathf.Round(player.transform.position.y);
	}
}
