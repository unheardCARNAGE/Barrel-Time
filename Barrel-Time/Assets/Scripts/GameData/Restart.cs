using UnityEngine;
using System.Collections;

public class Restart : MonoBehaviour {
    public SpriteRenderer gameOver;
     public GameObject playerPrefab;
     public Transform playerTransform;
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
	
	}

    public void restartGame()
    {
          if (gameOver.enabled)
          {
               ScoreManager.score = 0;
               gameOver.enabled = false;
               Instantiate(playerPrefab, playerPosition, playerRotation);
               gameObject.SetActive(false);
          }
    }
}
