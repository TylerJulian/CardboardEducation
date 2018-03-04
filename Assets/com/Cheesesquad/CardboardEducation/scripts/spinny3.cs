using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinny3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.Rotate(Vector3.up * 45 * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * 45 * Time.deltaTime);
    }
}
