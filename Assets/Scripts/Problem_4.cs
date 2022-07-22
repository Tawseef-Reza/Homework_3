using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_4 : MonoBehaviour
{
    /* Create a List of numbers that are odd and are divisible by the number 7 between 1 and 144.
     * You should have a list that looks like this 7, 21, 35, 49, 63, 77, 91, 105, 119, 133
     * Declare an array that's half the size of the list and save every other number from the list into the array 
     * You should have a array that looks like this 7, 35, 63, 91, 119
    */
    void Start()
    {
        List<int> divisibleBy7 = new List<int>();
        for (int i = 1; i <= 144; i+=2)
        {
            if (i % 7 == 0)
            {
                divisibleBy7.Add(i);
            }
        }
        int[] halfList = new int[divisibleBy7.Count / 2];
        int arrayIndex = 0; // arrayIndex represents index number of array
        for (int i = 0; i < divisibleBy7.Count; i+=2) // i represents index number of list
        {
            halfList[arrayIndex] = divisibleBy7[i];
            arrayIndex++;
        }
        
        //printing list out
        foreach (int i in divisibleBy7)
        {
            print(i);
        }
        //printing array out
        foreach (int i in halfList)
        {
            print(i);
        }
    }
}
