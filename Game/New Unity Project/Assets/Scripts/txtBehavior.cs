using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class txtBehavior : MonoBehaviour
{
    static public bool button1, button2, button3;


    public void Button1Clicked()
    {
        button1 = true;
    }

    public  void Button2Clicked()
    {
        button2 = true;
    }


    public  void Button3Clicked()
    {
        button3 = true;
    }

}