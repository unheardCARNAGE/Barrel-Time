using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
    public SpriteRenderer gameOver;
	
    // Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void restartGame()
    {
        ScoreManager.score = 0;
        gameOver.enabled = false;
     

    }
}
