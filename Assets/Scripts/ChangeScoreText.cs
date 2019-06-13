using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeScoreText : MonoBehaviour {

    public GameObject player;
	
	// Update is called once per frame
	void Update () {
        GetComponent<Text>().text = "Score: " + player.GetComponent<ScoreSystem>().score;
	}
}
