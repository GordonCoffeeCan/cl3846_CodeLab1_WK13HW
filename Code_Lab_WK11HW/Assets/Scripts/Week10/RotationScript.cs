using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationScript : MonoBehaviour {

    private float rotateSpeed;

    private Vector3 angle;

	// Use this for initialization
	void Start () {
        angle = new Vector3(Random.Range(0, 10), Random.Range(0, 10), Random.Range(0, 10));
        rotateSpeed = Random.Range(5, 20);
    }
	
	// Update is called once per frame
	void Update () {
        this.transform.Rotate(angle * rotateSpeed * Time.deltaTime);
	}
}
