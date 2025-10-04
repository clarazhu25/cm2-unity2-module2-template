using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateDestroy : MonoBehaviour
{
    // EXERCISE 2.5.1: Create variables below 
    public GameObject prefab;
    public GameObject Spacebar;
    public float DelayDestroy = 0.8f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject clone = Instantiate(prefab);
            Destroy(clone, DelayDestroy);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject clone = Instantiate(spacebar);
        }
        // EXERCISE 2.5.2: Finish code below
            /*
            if (LEFT MOUSE CLICKED)
            {
                CREATE CLONE OF PREFAB
                DESTROY IN DELAYDESTROY SECONDS
            }
            */
            //END OF CODE
    }
}
