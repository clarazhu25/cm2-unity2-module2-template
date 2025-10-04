using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExampleFile : MonoBehaviour
{
    public int visibleNumber;
    private int hiddenNumber;

    public void AddNumber()
    {
        // While the variable and method are hidden, 
        // it can still be accessed by the public method,
        // since it is part of the same class.
        AddToVisible();
        hiddenNumber++;
    }

    // Only this script can call this method
    private void AddToVisible()
    {
        visibleNumber++;
    }
    
}
