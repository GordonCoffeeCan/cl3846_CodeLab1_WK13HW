using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicGun : MonoBehaviour {

    protected string name = "BasicGun";

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public virtual void Fire() {
        print("Fired a basic shot: " + name);

        GameObject bullet = Instantiate(Resources.Load("Prefabs/Balloon"), this.transform.position, Quaternion.identity) as GameObject;
    }
}
