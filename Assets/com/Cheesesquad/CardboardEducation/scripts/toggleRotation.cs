using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class toggleRotation : MonoBehaviour {
    public bool spinQ = false;
    // Use this for initialization
    void Start() {

        


    }

    // Update is called once per frame
    void Update() {
        if (spinQ == true)
    {

            transform.Rotate(Vector3.up * 5 * Time.deltaTime);

        }


    }

    public void Toggle()
    {
        spinQ = !spinQ;
    }
    public void enter() {
        spinQ = false;
                            }
    public void exit()
    {
        spinQ = true;
    }

}
