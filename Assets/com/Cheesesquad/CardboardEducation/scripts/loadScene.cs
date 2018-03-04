using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {



public void scenePhysics() {
        
        SceneManager.LoadScene("physicallySick"); }
public void sceneChem() {
        
        SceneManager.LoadScene("test"); }
public void sceneElectro() {
        
        SceneManager.LoadScene("Electric"); }
public void goHome() { SceneManager.LoadScene("Menu"); }


}


