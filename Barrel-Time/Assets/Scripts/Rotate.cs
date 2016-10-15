using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
     Vector3 rotationVector;
     float rotationMagnitude;
     void Awake () {
          rotationMagnitude = 0.5f;
          rotationVector = new Vector3(0f, 0f, rotationMagnitude);
     }
	// Use this for initialization
	void Start () {
          
	}
	
	// Update is called once per frame
	void Update () {
          transform.Rotate(rotationVector);
	}
}
