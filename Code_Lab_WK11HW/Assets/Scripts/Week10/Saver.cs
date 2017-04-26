using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saver : MonoBehaviour {
    private AsteriodData ad;

	// Use this for initialization
	void Start () {
 
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.S)) {
            ad = new AsteriodData(WK10Manager._asteroidsList.Count);
            ad.Save("Asteroid.json");
        }
	}
}
