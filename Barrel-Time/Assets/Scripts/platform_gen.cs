using UnityEngine;
using System.Collections;

public class platform_gen : MonoBehaviour {

    public GameObject squarePrefab;

    void awake()
    {
        Instantiate(squarePrefab, new Vector3(0, 0, 0), Quaternion.identity);
    }
	// Use this for initialization
	void Start () {
	    
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
