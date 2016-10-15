using UnityEngine;
using System.Collections;

public class GameOver : MonoBehaviour {

    public SpriteRenderer gameOver;
	// Use this for initialization
	void Start () {
        gameOver = gameObject.GetComponent<SpriteRenderer>();
        gameOver.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DisplayScreen()
    {
        gameOver.enabled = true;
    }

}
