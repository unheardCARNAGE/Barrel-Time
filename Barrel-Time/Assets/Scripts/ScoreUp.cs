using UnityEngine;
using System.Collections;

public class ScoreUp : MonoBehaviour {

  private bool give_score;

  void OnCollisionEnter2D(){
    if (give_score) {
      ScoreManager.score += 100;
      give_score = false;
    }

  }

  void Start () {
    give_score = true;
	}
	
	// Update is called once per frame
	void Update () {
	    
	}
}
