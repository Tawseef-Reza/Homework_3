using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problem_3 : MonoBehaviour
{
    /*
     * Using the names array create inputs into the index Names List consisting of "n. " + name
     * Such that when you print out the List you will see 
     * 1. Clark
     * 2. Bruce
     * 3. Diana
     * 4. Barry
     * 5. Hal
     * 6. Arthur 
     */
    void Start()
    {
        string[] names = new string[6]{ "Clark", "Bruce", "Diana", "Barry", "Hal", "Arthur"};
        List<string> indexedNames = new List<string>();
        foreach (string i in names)
        {
            indexedNames.Add(i);
        }
        for (int i = 0; i < indexedNames.Count; i++) // printing out list items
        {
            print(indexedNames[i]);
        }
        
    }
}
