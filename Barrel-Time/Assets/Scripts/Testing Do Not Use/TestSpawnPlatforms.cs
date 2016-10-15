using UnityEngine;
using System.Collections;

public class TestSpawnPlatforms : MonoBehaviour {

  public TestPlatformMove platform;
  public float spawn_rate;
  private float timer;

	// Use this for initialization
	void Start () {
    timer = spawn_rate;
	}
	
  Vector2 polarToCoord(float theta,float radius) {
    float y = Mathf.Sin(theta) * radius;
    float x = Mathf.Cos(theta) * radius;
    return new Vector2(x, y);
  }

	// Update is called once per frame
	void Update () {
    if (timer >= spawn_rate && spawn_rate > 0) {
      timer -= spawn_rate;
      TestPlatformMove go = (TestPlatformMove)Instantiate(platform);
      go.transform.parent = transform;
      go.transform.localPosition = new Vector3(-9, 0);
    }
    timer += Time.deltaTime;
	}
}
