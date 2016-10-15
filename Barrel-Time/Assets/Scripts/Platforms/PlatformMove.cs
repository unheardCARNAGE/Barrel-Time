using UnityEngine;
using System.Collections;

public class PlatformMove : MonoBehaviour {

  private bool has_been_seen;

	void Start () {
	
	}
	
	void Update () {
	}

  void OnBecameInvisible() {
    if (has_been_seen) {
      Destroy(gameObject);
    }
  }

  void OnBecameVisible() {
    has_been_seen = true;
  }

}
