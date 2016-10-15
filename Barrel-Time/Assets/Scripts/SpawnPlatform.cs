using UnityEngine;
using System.Collections;

public class SpawnPlatform : MonoBehaviour
{
     public GameObject platform;
     // Use this for initialization
     void Start()
     {
          (GameObject.Instantiate(platform) as GameObject).transform.parent = transform;
     }

     // Update is called once per frame
     void Update()
     {

     }
}