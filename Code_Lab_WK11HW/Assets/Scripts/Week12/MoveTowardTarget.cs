using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTowardTarget : MonoBehaviour {

    public Transform target;
    public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 dir = target.position - transform.position;

        Debug.DrawRay(transform.position, dir, Color.magenta);

        dir.Normalize();

        if(Vector3.Dot(transform.forward, dir) > 0) {
            Debug.DrawRay(transform.position, dir, Color.green);
        } else {
            Debug.DrawRay(transform.position, dir, Color.red);
        }

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), speed);

        transform.Translate(dir * speed * Time.deltaTime);
		
	}
}
