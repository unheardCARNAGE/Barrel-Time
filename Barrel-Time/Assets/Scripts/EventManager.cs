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
    Application.LoadLevel("HardMode");
  }

  public void loadEasyMode() {
        //
        Application.LoadLevel("EasyMode");
  }

  public void loadMenu()
    {
        Application.LoadLevel("MainMenu");
    }

  public void quitGame() {
    Application.Quit();
  }
}
