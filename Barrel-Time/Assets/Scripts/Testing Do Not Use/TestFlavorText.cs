using UnityEngine;
using System.Collections;

public class TestFlavorText : MonoBehaviour {

  public string[] texts;
  public float threshhold;

  private float counter;
  private GUIText display;

  void OnAwake() {
    display = GetComponent<GUIText>();
  }

	// Use this for initialization
	void Start () { 

	}
	
	// Update is called once per frame
	void Update () {
    if (counter >= threshhold) {

    }
	}
}
