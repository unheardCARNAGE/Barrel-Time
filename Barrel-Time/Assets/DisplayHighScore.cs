using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DisplayHighScore : MonoBehaviour {

  private Text display;

	// Use this for initialization
	void Start () {
    display = GetComponent<Text>();
    display.text = "High Score: " + PlayerPrefs.GetInt("Score", 0);
  }

  // Update is called once per frame
  void Update() {

  }

  public void resetHighscore() {
    display.text = "High Score: " + PlayerPrefs.GetInt("Score", 0);
  }

}
