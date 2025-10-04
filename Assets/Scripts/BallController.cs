using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BallController : MonoBehaviour
{
    public TMP_Text updateText;
    public TMP_Text fixedUpdateText;
    // EXERCISE 2.4.1: Declare and intialize updateCounter, fixedUpdateCounter, and mr here
    // Start is called before the first frame update
    public float updateCounter;
    public float fixedUpdateCounter;
    private MeshRenderer mr;
    void Start()
    {
        mr = GetComponent<MeshRenderer>();

        // EXERCISE 2.4.2: Set mr to get MeshRenderer component here
    }

    // Update is called once per frame
    void Update()
    {
        mr.enabled = false;
        updateCounter++;
        // EXERCISE 2.4.2: Disable MeshRenderer component

        // EXERCISE 2.4.3: Increment updateCounter by 1

        // EXERCISE 2.4.3: Uncomment this once completed.
        updateText.text = "Update Counter: " + updateCounter.ToString();
    }

    void FixedUpdate()
    {
        fixedUpdateCounter = fixedUpdateCounter + 1;
        fixedUpdateText.text = "fixed Update Counter:" + fixedUpdateCounter.ToString();
    }

    // EXERCISE 2.4.3 Create FixedUpdate function below.
    // Increment fixedUpdateCounter by 1.
    // update fixedUpdateText to say "Fixed Update Counter: " + fixedUpdateCounter.ToString()
}
