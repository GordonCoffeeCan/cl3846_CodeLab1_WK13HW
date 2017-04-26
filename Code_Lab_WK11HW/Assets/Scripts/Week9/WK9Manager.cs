using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WK9Manager : MonoBehaviour {

	// Use this for initialization
	void Start () {
        HighScore hs1 = new HighScore();
        hs1.name = "Someone";
        hs1.position = 2;
        hs1.score = 10;

        HighScore hs2 = new HighScore();
        hs2.name = "Gordon";
        hs2.position = 2;
        hs2.score = 10;

        HighScore hs3 = new HighScore();
        hs3.name = "Test";
        hs3.position = 3;
        hs3.score = 1;

        hs1.next = hs2;
        hs2.prev = hs1;
        hs2.next = hs3;
        hs3.prev = hs2;

        HighScore current = hs1;

        print(current.name);
        print(current.next.next.name);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
