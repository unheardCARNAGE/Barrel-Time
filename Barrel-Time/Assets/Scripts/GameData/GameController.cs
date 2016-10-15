using UnityEngine;
using System.Collections;

public class GameController : Singleton<GameController> {

     protected GameController() {} //Prevents instantiation

     public static void EndGame() {
          if(Application.isEditor)
               UnityEditor.EditorApplication.isPlaying = false;
          Application.Quit();
     }
}
