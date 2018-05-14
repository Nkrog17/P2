using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(BoxCollider))]
public class Behavoir : MonoBehaviour
{

    public Vector3 screenPoint;
    public Vector3 offset;

    public GameObject redMoveble, blueMoveable, purpleMoveable, greenMoveable;

    public GameObject red, blue, green, purple;

    public string Col;

    public static int numberOfCollidersCorrect;

    void Update()
    {
        CheckPos(-6f, 6f, 4.5f, -4.5f);

    }

    // makes the objects draggable
    void OnMouseDown()
    {
        offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
    }

    void OnMouseDrag()
    {
        if (tag.Equals("Moveable"))
        {
            Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
            Vector3 curPosition = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
            this.transform.position = curPosition;
        }
    }

    // limits on the gameobjects positions in the window
    void CheckPos(float n, float m, float l, float k)
    {
        if (transform.position.x < -7.5f)
        {
            Vector3 temp = new Vector3(n, transform.position.y, transform.position.z);
            transform.position = temp;
        }
        if (transform.position.x > 7.5f)
        {
            Vector3 temp = new Vector3(m, transform.position.y, transform.position.z);
            transform.position = temp;
        }
        if (transform.position.y > 5.5)
        {
            Vector3 temp = new Vector3(transform.position.x, l, transform.position.z);
            transform.position = temp;
        }
        if (transform.position.y < -5.5)
        {
            Vector3 temp = new Vector3(transform.position.x, k, transform.position.z);
            transform.position = temp;
        }
    }

    // compare 
    void OnTriggerEnter(Collider other)
    {

        if (other.tag.Equals("Moveable") && gameObject.tag.Equals("Untagged"))
        {
            Behavoir temp = other.gameObject.GetComponent<Behavoir>();
            BoxCollider boxcolliderOther = other.GetComponent<BoxCollider>();
            BoxCollider boxcolliderThisObject = GetComponent<BoxCollider>();
            if (boxcolliderThisObject.enabled)
            {
                if (Col.Equals("red") && temp.Col.Equals("green"))
                {
                    Debug.Log("red and green");
                    numberOfCollidersCorrect += 1;

                    other.transform.position = new Vector3(other.transform.position.x, transform.position.y, other.transform.position.z);

                    boxcolliderOther.isTrigger = true;


                    boxcolliderThisObject.enabled = !boxcolliderThisObject.enabled;
                    other.gameObject.tag = "Not Moveable";
                }
                else if (Col.Equals("green") && temp.Col.Equals("red"))
                {
                    Debug.Log("green and red");
                    numberOfCollidersCorrect += 1;

                    other.transform.position = new Vector3(other.transform.position.x, transform.position.y, other.transform.position.z);

                    boxcolliderOther.isTrigger = true;

                    boxcolliderThisObject.enabled = !boxcolliderThisObject.enabled;

                    other.gameObject.tag = "Not Moveable";
                }
                else if (Col.Equals("blue") && temp.Col.Equals("purple"))
                {
                    Debug.Log("blue and purple");
                    numberOfCollidersCorrect += 1;

                    other.transform.position = new Vector3(other.transform.position.x, transform.position.y, other.transform.position.z);
                    boxcolliderOther.isTrigger = true;

                    boxcolliderThisObject.enabled = !boxcolliderThisObject.enabled;
                    other.gameObject.tag = "Not Moveable";
                }
                else if (Col.Equals("purple") && temp.Col.Equals("blue"))
                {
                    Debug.Log("purple and blue");
                    numberOfCollidersCorrect += 1;

                    other.transform.position = new Vector3(other.transform.position.x, transform.position.y, other.transform.position.z);
                    boxcolliderOther.isTrigger = true;

                    boxcolliderThisObject.enabled = !boxcolliderThisObject.enabled;

                    other.gameObject.tag = "Not Moveable";
                }
                else
                {
                    //numberOfCollidersCorrect --;
                    other.gameObject.tag = "Moveable";
                }
            }
            Debug.Log(numberOfCollidersCorrect);
            //Debug.Log("now!");
        }
    }

}

