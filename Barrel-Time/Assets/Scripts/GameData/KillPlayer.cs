using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Lava")
        {
            Destroy(gameObject);
            var dead = GameObject.FindObjectOfType<GameOver>();
            dead.DisplayScreen();
        }
    }

    public void Update()
    {
    }

	public void OnBecameInvisible() {
          //GameController.EndGame();
     }
}
