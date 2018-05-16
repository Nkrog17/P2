using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectSQL : MonoBehaviour {

	public int sqlID;
	private bool inList = false;
	public GameObject currentlist;
	public float width;
	Vector3 ogpos;

	// Use this for initialization
	void Start () {
		//currentlist.GetComponent<SQLString>().sqlList;
		width = gameObject.GetComponent<Renderer>().bounds.size.x;
		ogpos = gameObject.transform.position;
	}

	// Update is called once per frame
	void Update () {
	}

	void OnMouseDown () {
		if (!inList) {
			AddToList ();
		} else {
			RemoveFromList ();
		}
		FindObjectOfType<click>().playClick();
	}

	void AddToList(){
		currentlist.GetComponent<SQLString>().sqlList.Add(this.gameObject);
		MovePosition ();
		inList = true;
	}

	void RemoveFromList(){
		currentlist.GetComponent<SQLString> ().sqlList.Remove (this.gameObject);
		MovePosition ();
		inList = false;
	}

	void MovePosition(){
		if (!inList) {
			//Move SQL piece to new position.
			transform.position = new Vector2 (currentlist.GetComponent<SQLString> ().xpos + width / 2, currentlist.GetComponent<SQLString> ().ypos);
			currentlist.GetComponent<SQLString> ().xpos += width + 0.1f;
		} else {
			Vector3 temppos = transform.position;
			transform.position = ogpos;
			currentlist.GetComponent<SQLString> ().xpos -= width + 0.1f;
			//Move all SQL pieces in the list.
			for (int i = 0; i < currentlist.GetComponent<SQLString> ().sqlList.Count; i++) {
				if (currentlist.GetComponent<SQLString> ().sqlList [i].transform.position.x > temppos.x) {
					currentlist.GetComponent<SQLString> ().sqlList [i].transform.position = new Vector2 (currentlist.GetComponent<SQLString> ().sqlList [i].transform.position.x - width - 0.1f, currentlist.GetComponent<SQLString> ().ypos);
				}
			}
		}
	}
}
