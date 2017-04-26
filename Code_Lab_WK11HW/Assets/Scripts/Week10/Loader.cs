using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour {
    public static AsteriodData loadAd;

    // Use this for initialization
    void Start () {
        if(SceneManager.GetActiveScene().buildIndex == 1) {
            loadAd = new AsteriodData("Asteroid.json");
        }
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
