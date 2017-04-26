using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TripleShot : BasicGun {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public override void Fire() {
        base.Fire();
        base.Fire();
        base.Fire();
        print("fire! fire! fire!");
    }
}
