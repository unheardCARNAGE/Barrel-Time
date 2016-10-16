using UnityEngine;
using System.Collections;

public class SpawnPlatforms : MonoBehaviour {

  public PlatformMove platform;
  public float spawn_rate;
  public float min_radius;
  public float max_radius;
  public float max_theta;
  public float min_theta;

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
      PlatformMove go = (PlatformMove)Instantiate(platform);

      float t = Random.Range(min_theta, max_theta);
      float r = Random.Range(min_radius, max_radius);

      Vector2 pPos = polarToCoord((Mathf.PI * 2f) * t, r);
      go.transform.Rotate(new Vector3(0, 0, 90 + (t * 360f)));
      go.transform.position = new Vector3(pPos.x+transform.position.x, pPos.y+transform.position.y, -1);
      go.transform.parent = transform;

    }
    timer += Time.deltaTime;
	}
}
