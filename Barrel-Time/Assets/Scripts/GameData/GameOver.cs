using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    private SpriteRenderer gameOver;
     public GameObject restartButton;
	// Use this for initialization
	void Start () {
        gameOver = gameObject.GetComponent<SpriteRenderer>();
        restartButton.SetActive(gameOver.enabled = false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DisplayScreen()
    {
          restartButton.SetActive(gameOver.enabled = true);
    }

}
