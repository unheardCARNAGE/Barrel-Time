using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
    public SpriteRenderer gameOver;
     public GameObject playerPrefab;
     public Transform playerTransform;
  public DisplayHighScore high_score_display;
     private Vector3 playerPosition;
     private Quaternion playerRotation;
     void Awake()
     {
          playerPosition = playerTransform.position;
          playerRotation = playerTransform.rotation;
     }
    // Use this for initialization
	void Start () {
          
	}
	
	// Update is called once per frame
	void Update () {
    if (Input.GetButtonDown("Jump") && gameOver.enabled) {
      restartGame();
    }
	}

    public void restartGame()
    {
          if (gameOver.enabled)
          {
               high_score_display.resetHighscore();
               ScoreManager.score = 0;
               gameOver.enabled = false;
               Instantiate(playerPrefab, playerPosition, playerRotation);
               gameObject.SetActive(false);
          }
    }
}
