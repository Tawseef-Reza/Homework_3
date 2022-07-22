using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_2 : MonoBehaviour
{
    /*
     * Using a loop go through the disorder array and print out true or false if the numbers are in rising order
     * It should be false, as 2 is smaller than 5. In order would be 0,2,5.
    */
    void Start()
    {
        int[] disorder = new int[3]{0,5,2};
        
        bool isInOrder = true; // set to true initially
        
        for (int i = 1; i < disorder.Length; i++) // i is equal to 1 because I dont want
                                                  // to start at the beginning since there
                                                  // is nothing to compare at the beginning
        {
            if (disorder[i] >= disorder[i-1])
            {
                isInOrder = true;
            }
            else
            {
                isInOrder = false;
                break;
            }
        }
        print(isInOrder);

    }
}
