﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreManager : MonoBehaviour {

    public static int score;
    Text text;

	// Use this for initialization
	void Awake () {

        text = GetComponent<Text>();
        score = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
        text.text = "" + score;

    }
}
 