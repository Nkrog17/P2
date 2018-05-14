using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    // arrays of objects.
    public GameObject[] prefabsDNA1;
    public GameObject[] prefabsDNA2;

    //arrays of moveableobjects
    public List<GameObject> MoveableObjects1;
    public List<GameObject> MoveableObjects2;

    // spawned objects
    public List<GameObject> initializedObejct1;
    public List<GameObject> initializedObejct2;


    //moveable objects.
    public GameObject redMoveable, purpleMoveable, greenMoveable, blueMoveable;
    //static object.
    public GameObject red, purple, green, blue;

    private bool spawn = true;


    public uWonText uWonText;



    // Use this for initialization
    void Start()
    {

        SpawnerOfObject();
        AddingObjectsToNewArray1();
        AddingObjectsToNewArray2();
        //Debug.Log(MoveableObjects2.Count);

        
    }

    // Update is called once per frame
    void Update()
    {
        if (spawn)
        {
                SpawnMoveable();
        }

        uWonText.WinCondition();
    }

    // spawning DNA string
    void SpawnerOfObject()
    {

        for (int i = 0; i < prefabsDNA1.Length; i++)
        {

            Instantiate(prefabsDNA1[i], new Vector3(-6.4f,4.5f-i,0f), Quaternion.identity);

            
            initializedObejct1.Add((prefabsDNA1[i]));
        }
        for (int i = 0; i < prefabsDNA2.Length; i++)
        {
            Instantiate(prefabsDNA2[i], new Vector3(6.4f, 4.5f - i, 0f), Quaternion.identity);


            initializedObejct2.Add((prefabsDNA2[i]));
        }
        
    }


    //adding new objects to arr 1
    void AddingObjectsToNewArray1()
    {

        for (int i = 0; i < initializedObejct1.Count; i++)
        {
            if (initializedObejct1[i].Equals(red))
            {
                MoveableObjects1.Add(greenMoveable);

                //Debug.Log("red");

            }
            else if (initializedObejct1[i].Equals(blue))
            {
                MoveableObjects1.Add(purpleMoveable);

                //Debug.Log("blue");
            }
            else if (initializedObejct1[i].Equals(green))
            {
                MoveableObjects1.Add(redMoveable);

                //Debug.Log("green");
            }
            else if (initializedObejct1[i].Equals(purple))
            {
                MoveableObjects1.Add(blueMoveable);

                //Debug.Log("purple");
            }

        }

    }
    
    //adding new objects to arr 2
    void AddingObjectsToNewArray2()
    {

        for (int i = 0; i < initializedObejct2.Count; i++)
        {

            if (initializedObejct2[i].Equals(red))
            {
                MoveableObjects2.Add(greenMoveable);

                //Debug.Log("red");

            }
            else if (initializedObejct2[i].Equals(blue))
            {
                MoveableObjects2.Add(purpleMoveable);

                //Debug.Log("blue");
            }
            else if (initializedObejct2[i].Equals(green))
            {
                MoveableObjects2.Add(redMoveable);

                //Debug.Log("green");
            }
            else if (initializedObejct2[i].Equals(purple))
            {
                MoveableObjects2.Add(blueMoveable);

                //Debug.Log("purple");
            }

        }

    }

    //spawning the moveable objects.
    void SpawnMoveable()
    {

        for (int i = 0; i < 10; i++)
        {
            
                Instantiate(MoveableObjects1[i], new Vector3(-0.5f, 4.5f - (i), 0f), Quaternion.identity);
                Instantiate(MoveableObjects2[i], new Vector3(0.5f, 4.5f - (i), 0f), Quaternion.identity);
            


            //Instantiate(SwappingIndex1()[i], new Vector3(-0.5f, 4.5f - (i), 0f), Quaternion.identity);
            //Instantiate(SwappingIndex2()[i], new Vector3(0.5f, 4.5f - (i) , 0f), Quaternion.identity);

        }

        spawn = false;

    }


    List<GameObject> SwappingIndex1() {


        for (int i = 0; i < 10; i++)
        {
            int ran = Random.Range(0, 9);

            
            // Chancing index posistion in array
            GameObject placeHolder = MoveableObjects1[ran];

            MoveableObjects1[ran] = MoveableObjects1[i];

            MoveableObjects1[i] = placeHolder;

        }
        return MoveableObjects1;
    }


    

    List<GameObject> SwappingIndex2()
    {


        for (int i = 0; i < 10; i++)
        {
            
            
            int ran = Random.Range(0, 9);

            // Chancing index posistion in array
            GameObject placeHolder2 = MoveableObjects2[i];

            MoveableObjects2[i] = MoveableObjects2[ran];

            MoveableObjects2[ran] = placeHolder2;


        }
        return MoveableObjects2;
    }

}
