using UnityEngine;
using System.Collections;

public class KillPlayer : MonoBehaviour {
	public void OnBecameInvisible() {
          GameController.EndGame();
     }
}
