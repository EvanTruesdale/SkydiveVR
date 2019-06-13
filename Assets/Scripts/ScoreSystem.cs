using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreSystem : MonoBehaviour {

    public int score;

    private void OnTriggerEnter(Collider externalCollider)
    {
        if(externalCollider.gameObject.tag == "Ring Hole"){
            Destroy(externalCollider.gameObject.transform.parent.gameObject);
            score++;
        }
    }
}
