using UnityEngine;
using System.Collections;

public class ScoreUp : MonoBehaviour {



    void OnCollisionEnter2D()
    {

        ScoreManager.score += 100;
    }
	// Use this for initialization
	void Start () {
        	
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
