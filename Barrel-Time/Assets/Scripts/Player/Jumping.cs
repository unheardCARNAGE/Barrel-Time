using UnityEngine;
using System.Collections;
using System;

public class Jumping : MonoBehaviour {


    public int points;
  public float vertical_speed;
  public float floating_length;
  public float gravity_scale;

  private bool start_falling;
  private float floating_timer;
  private bool is_floating;

  private Rigidbody2D player_rigid_body;

  void Awake() {
    player_rigid_body = GetComponent<Rigidbody2D>();
    floating_timer = 0;
    player_rigid_body.gravityScale = 0;
    is_floating = false;
  }

	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
    if (start_falling == false && Input.GetKeyDown(KeyCode.Space)) {
      start_falling = true;
      player_rigid_body.gravityScale = gravity_scale;
    }

    if (start_falling) {
      if (floating_timer > 0 && is_floating) {
        floating_timer -= Time.deltaTime;
      }

      if (floating_timer < 0 && is_floating) {
        is_floating = false;
        player_rigid_body.gravityScale = gravity_scale;
      }

      if (is_floating && Input.GetKeyUp(KeyCode.Space)) {
        is_floating = false;
        player_rigid_body.gravityScale = gravity_scale;
      }

      if (isGrounded() && Input.GetKeyDown(KeyCode.Space)) {
        player_rigid_body.velocity = new Vector3(0, vertical_speed, 0);
        player_rigid_body.gravityScale = 0;
        floating_timer = floating_length;
        ScoreManager.score += points;
        is_floating = true;
      }
    }
    
	}

  bool isGrounded() {
    RaycastHit2D[] rightHits = Physics2D.RaycastAll(transform.position + (Vector3.right * 0.4f), -Vector3.up, 0.2f);
    RaycastHit2D[] leftHits = Physics2D.RaycastAll(transform.position + (Vector3.left * 0.4f), -Vector3.up, 0.2f);
    RaycastHit2D[] centerHits = Physics2D.RaycastAll(transform.position, -Vector3.up, 0.2f);

    //print(centerHits.Length);

    if (raycastArrayContainsObjectWithTag(leftHits, "Floor")) {
      return true;
    }

    if (raycastArrayContainsObjectWithTag(leftHits, "Floor")) {
      return true;
    }

    if (raycastArrayContainsObjectWithTag(centerHits,"Floor")) {
      return true;
    }

    return false;
  }

  bool raycastArrayContainsObjectWithTag(RaycastHit2D[] hits, string tag) {
    foreach (RaycastHit2D hit in hits) {
      if (hit.transform.tag == tag) {
        return true;
      }
    }
    return false;
  }
}
