using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SimpleJSON;

public class AsteriodData {

    public int num;
    public Vector3 position;

    public List<Vector3> positionsList = new List<Vector3>();

    private const string NUM = "num";
    private const string POS_X = "xpos";
    private const string POS_Y = "ypos";
    private const string POS_Z = "zpos";


    public AsteriodData(string _fileName) {
        JSONNode jason = UtilScript.ReadJSONfromFile(Application.dataPath, _fileName);
        this.num = jason[NUM].AsInt;

        for (int i = 0; i < this.num; i++) {
            this.positionsList.Add(new Vector3(jason[POS_X + i].AsFloat, jason[POS_Y + i].AsFloat, jason[POS_Z + i].AsFloat));
        }
    }

    public AsteriodData(int _num) {
        this.num = _num;
    }

    public JSONClass ToJSON() {
        JSONClass json = new JSONClass();
        for (int i = 0; i < num; i++) {
            json[NUM].AsInt = num;
            json[POS_X + i].AsFloat = WK10Manager._asteroidsList[i].transform.position.x;
            json[POS_Y + i].AsFloat = WK10Manager._asteroidsList[i].transform.position.y;
            json[POS_Z + i].AsFloat = WK10Manager._asteroidsList[i].transform.position.z;
        }
        

        return json;
    }

    public void Save(string fileName) {
        JSONClass json = ToJSON();

        UtilScript.WriteJSONtoFile(Application.dataPath, fileName, json);
    }
	
}
