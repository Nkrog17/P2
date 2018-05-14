using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SQLString : MonoBehaviour {

	public List<GameObject> sqlList = new List<GameObject> ();
	public float xpos;
	public float ypos;
	public GameObject errorstring;
	public GameObject randomentries;
	public GameObject ulrikentry;
    public GameObject done;
	bool errorstringon;
	int x;
	public bool puzzledone;

	// Use this for initialization
	void Start () {
		errorstring.SetActive (false);
		ulrikentry.SetActive (false);
        done.SetActive(false);

    }
	
	// Update is called once per frame
	void Update () {
		if (errorstringon) {
			x += 1;
			if (x >= 150) {
				errorstringon = false;
				errorstring.SetActive (false);
				x = 0;
			}
		}
	}

	void Error(){
		errorstring.SetActive (true);
		errorstringon = true;
	}

	void SortTable(){
		randomentries.SetActive (false);
		ulrikentry.SetActive (true);
		puzzledone = true;
        done.SetActive(true);


    }

	public void checkSQL () {
		errorstring.SetActive (false);
		bool error = false;
		//Check if the SQL is right.
		if (sqlList.Count == 6) {
			for (int i = 0; i < sqlList.Count; i++) {
				//Return error in SQL
				if (sqlList [i].GetComponent<selectSQL> ().sqlID != i) {
					Error ();
					error = true;
					break;
				}
			}
			//Corrent SQL - sort table.
			if (!error) {
				SortTable ();
			}
		} else {
			Error();
		}
	}
}
