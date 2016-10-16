using UnityEngine;
using System.Collections;

public class EventManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

  public void loadHardMode() {
    //Application.LoadLevel();
  }

  public void loadEasyMode() {
    //
  }

  public void quitGame() {
    Application.Quit();
  }
}
