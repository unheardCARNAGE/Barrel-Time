using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour {

    private SpriteRenderer gameOver;
     public GameObject restartButton;
  public AudioClip[] sounds;
  private AudioSource source;

	// Use this for initialization
	void Start () {
        gameOver = gameObject.GetComponent<SpriteRenderer>();
    source = GetComponent<AudioSource>();
        restartButton.SetActive(gameOver.enabled = false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void DisplayScreen()
    {
          restartButton.SetActive(gameOver.enabled = true);
        source.Play();

    }
}
