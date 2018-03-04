using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class toggleRotation : MonoBehaviour {
    public bool spinQ = true;
    // Use this for initialization
    void Start() {
        if (spinQ == true)
        {

            transform.Rotate(Vector3.up * 15 * Time.deltaTime);

        }



    }

    // Update is called once per frame
    void Update() {
        if (spinQ == true)
    {

            transform.Rotate(Vector3.up * 15 * Time.deltaTime);

        }


    }

    public void enter() {
        spinQ = false;
                            }
    public void exit()
    {
        spinQ = true;
    }

}
