using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CubeController : MonoBehaviour
{
    public TMP_Text scoreText;
    private int currentNum;
    public int score = 0;
    public Vector3 position;


    // Start is called before the first frame update
    void Start()
    {
        currentNum = 0;
        // EXERCISE 2-3: INITIALIZE CURRENTNUM HERE
    }

    // Update is called once per frame
    void Update()
    {
        // currentNum = currentNum + 1;
        // Debug.Log(currentNum);


        if (Input.GetKey(KeyCode.Mouse0))
        {
            score = score + 1;
            scoreText.text = "The Score is: " + score.ToString();
        }

        if (Input.GetKey(KeyCode.Space))
        {
            score = score - 1;
            scoreText.text = "the score is: " + score.ToString();
        }

    }

    
}
