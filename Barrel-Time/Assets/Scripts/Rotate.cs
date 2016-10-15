using UnityEngine;
using System.Collections;

public class Rotate : MonoBehaviour {
     Vector3 rotationVector;
     public float rotationMagnitude;
     void Awake () {
          rotationVector = new Vector3(0f, 0f, rotationMagnitude) * Time.deltaTime;
     }
	// Use this for initialization
	void Start () {
          
	}
	
	// Update is called once per frame
	void Update () {
          transform.Rotate(rotationVector);
	}
}
