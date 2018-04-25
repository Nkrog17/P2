using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextsMethods : MonoBehaviour {

    public Text one;
    public Text two;
    public Text three;

    public Text question;

    public GameObject vis;

    private void Start()
    {
        vis.SetActive(false);
    }

    public void setText1 (string aug){
        one.text = aug;
       }

    public void setText2 (string aug)
    {
        two.text = aug;
    }

    public void setText3(string aug)
    {
        three.text = aug;
    }

    public void setQuestion(string aug)
    {
        question.text = aug;
    }

    public void turnOffObject()
    {
        vis.SetActive(false);

    }

    public void turnOnObject()
    {
        vis.SetActive(true);
    }
}
