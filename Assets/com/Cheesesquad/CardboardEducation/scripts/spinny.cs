using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinny : MonoBehaviour {

	// Use this for initialization
	void Start () {
        transform.Rotate(Vector3.up * 50 * Time.deltaTime);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * 50 * Time.deltaTime);
    }
}
