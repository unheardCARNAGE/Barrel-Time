using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

  public float vertical_speed;
  private Rigidbody2D player_rigid_body;
  private bool can_jump = false;

  void Awake() {
    player_rigid_body = GetComponent<Rigidbody2D>();
  }

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
    if (can_jump && Input.GetKeyDown(KeyCode.Space)) {
      player_rigid_body.velocity = new Vector3(0, vertical_speed, 0);
    }
	}

  void OnCollisionEnter2D(Collision2D coll) {
    can_jump = true;
  }

  void OnCollisionExit2D(Collision2D coll) {
    can_jump = false;
  }
}
