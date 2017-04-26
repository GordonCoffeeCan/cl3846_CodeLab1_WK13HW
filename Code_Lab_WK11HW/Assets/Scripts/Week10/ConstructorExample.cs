using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConstructorExample {

    public float temp;
    public string name;
    public GameObject _enemy;
    public int someInt;
    public bool isCool;


    //Constructor
    public ConstructorExample() {
        Debug.Log("Made a loader");

        temp = 10;
        name = "no name";
        someInt = 10;
        isCool = true;
    }

    public ConstructorExample(float _temp, string _name) {
        this.temp = _temp;
        this.name = _name;
    }
	
}
