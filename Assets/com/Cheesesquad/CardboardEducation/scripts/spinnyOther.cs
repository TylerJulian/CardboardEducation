using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spinnyOther : MonoBehaviour {
    private static readonly Random getrandom = new Random();
    // Use this for initialization
    float dice;
    void Start () {
        transform.Rotate(Vector3.down * 50 * Time.deltaTime);
       

    }
	
	// Update is called once per frame
	void Update () {

        dice = (Random.Range(40.0f, 100.0f));

        transform.Rotate(Vector3.down * dice * Time.deltaTime);
    }
}
