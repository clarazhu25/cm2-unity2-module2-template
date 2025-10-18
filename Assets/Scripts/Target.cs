using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(1, 1, 0));
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(this.gameObject);
    }

    // EXERCISE 2.7.1: Create OnTriggerEnter function here

}
