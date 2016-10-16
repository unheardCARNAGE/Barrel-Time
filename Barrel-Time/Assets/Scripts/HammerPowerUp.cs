using UnityEngine;
using System.Collections;

public class HammerPowerUp : MonoBehaviour {
    public float timeLimit;
    //public float timer;

    private GameObject player;
    private Jumping jumpScript;
    private float timer;
    private float elapsed;
    private float movement;
    private int originalPoints;

	// Use this for initialization
	void Start ()
    {
        movement = .2f;
        player = GameObject.FindGameObjectWithTag("Player");
        jumpScript = player.GetComponent<Jumping>();
        originalPoints = jumpScript.points;
    }


    void Update()
    {
        timeLimit -= Time.deltaTime;
        transform.position = new Vector3(transform.position.x + movement, transform.position.y, transform.position.z);
        if (timeLimit <= 0)
            DestroyHammer();
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Renderer>().enabled = false;
            jumpScript.points *= 2;
        }
    }

    public void DestroyHammer()
    {
        jumpScript.points = originalPoints;
        //print(originalPoints.ToString());
        Destroy(gameObject);

    }

    private void OnDestroy()
    {
        //jumpScript.points = originalPoints;
    }
}
