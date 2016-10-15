using UnityEngine;
using System.Collections;

public class Jumping : MonoBehaviour {

  public float vertical_speed;
  private Rigidbody2D player_rigid_body;

  void Awake() {
    player_rigid_body = GetComponent<Rigidbody2D>();
  }

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
    isGrounded();
    if (isGrounded() && Input.GetKeyDown(KeyCode.Space)) {
      player_rigid_body.velocity = new Vector3(0, vertical_speed, 0);
    }
	}

  bool isGrounded() {
    bool a = Physics.Raycast(transform.position, -Vector3.up, 1f);
    if (a) {
      print("hoi");
    }
    return a;
  }
}
