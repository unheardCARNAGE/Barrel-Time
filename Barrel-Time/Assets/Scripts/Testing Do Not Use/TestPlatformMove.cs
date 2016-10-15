using UnityEngine;
using System.Collections;

public class TestPlatformMove : MonoBehaviour {

  public float move_speed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    Vector3 temp_pos = transform.position;
    temp_pos.x += move_speed * Time.deltaTime;
    transform.position = temp_pos;
	}
}
