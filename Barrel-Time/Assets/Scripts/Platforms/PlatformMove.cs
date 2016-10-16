using UnityEngine;
using System.Collections;

public class PlatformMove : MonoBehaviour {

  private bool has_been_seen;
  public float despawn_time;
  private float timer;

	void Start () {
    timer = 0;
	}
	
	void Update () {
    if (timer >= despawn_time) {
      Destroy(gameObject);
    }

    timer += Time.deltaTime;
	}

  /*
  void OnBecameInvisible() {
    if (has_been_seen) {
      Destroy(gameObject);
    }
  }

  void OnBecameVisible() {
    has_been_seen = true;
  }*/

}
