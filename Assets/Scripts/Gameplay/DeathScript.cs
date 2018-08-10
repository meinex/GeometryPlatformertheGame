using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
 
 
public class DeathScreenScript : MonoBehaviour {
    public bool death;
    [SerializeField] GameObject canvas;
    void Start() {
        canvas.SetActive (false);
    }
 
    void Update() {
        if (death) {
            ShowDeathScreen ();
        }
    }
 
    public void ShowDeathScreen() {
        canvas.SetActive (true);
    }
 
    public void Retry() {
        canvas.SetActive (false);
        death = false;
    }
 
}