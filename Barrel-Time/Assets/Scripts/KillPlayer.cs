using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {

    public void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Lava")
        {
            Destroy(gameObject);
        }
    }

    public void Update()
    {
    }

	public void OnBecameInvisible() {
          GameController.EndGame();
     }
}
