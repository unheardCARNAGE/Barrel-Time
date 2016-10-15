using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TestFlavorText : MonoBehaviour {

  public string[] texts;
  public float threshhold;

  private float counter;
  private Text display;

  void Awake() {
    display = GetComponent<Text>();
    display.text = getRandomFromTexts();
  }

	// Use this for initialization
	void Start () { 

	}
	
	// Update is called once per frame
	void Update () {

    if (counter > ScoreManager.score % threshhold) {
      display.text = getRandomFromTexts();
    }

    counter = ScoreManager.score % threshhold;
	}

  string getRandomFromTexts() {
    return texts[Random.Range(0,texts.Length)];
  }
}
