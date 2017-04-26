using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WK10Manager : MonoBehaviour {

    public int asteroidNum = 50;

    public static List<GameObject> _asteroidsList;

    private int currentSceneIndex;


    //private ConstructorExample myLoader;

	// Use this for initialization
	void Start () {
        _asteroidsList = new List<GameObject>();
        currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

       if(currentSceneIndex == 0) {
            for(int i = 0; i < asteroidNum; i++) {
                int j = i % 5;
                Debug.Log(j);
                GameObject _asteroid = Instantiate(Resources.Load("Prefabs/rock" + j) as GameObject);
                _asteroid.transform.position = new Vector3(Random.Range(-8f, 8f), Random.Range(-8f, 8f), Random.Range(-8f, 8f));
                _asteroidsList.Add(_asteroid);
            }
            
        }
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.N)) {
            if(currentSceneIndex == 0) {
                SceneManager.LoadScene(1, LoadSceneMode.Single);
            }
        }

        if (Input.GetKeyDown(KeyCode.L)) {
            if (currentSceneIndex == 1) {
                for (int i = 0; i < Loader.loadAd.num; i++) {
                    int j = i % 5;
                    GameObject _asteroid = Instantiate(Resources.Load("Prefabs/rock" + j) as GameObject);
                    _asteroid.transform.position = Loader.loadAd.positionsList[i];
                }
            }
        }
	}
}
