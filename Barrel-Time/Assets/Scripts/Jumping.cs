using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

  public float vertical_speed;
  private Rigidbody2D player_rigid_body;
  private bool can_jump;

  void Awake() {
    can_jump = false;
    player_rigid_body = GetComponent<Rigidbody2D>();
  }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    if (can_jump && Input.GetKeyDown(KeyCode.Space)) {
      player_rigid_body.velocity = new Vector3(0, vertical_speed, 0);
      can_jump = false;
    }

    if(Mathf.Abs(player_rigid_body.velocity.y) > 0) {
      can_jump = true;
    }
	}
}
