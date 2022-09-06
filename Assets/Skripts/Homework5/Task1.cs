using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task1 : MonoBehaviour
{
 
    void Start()
    {
        var people = new Dictionary<int, string>()
        {
            { 5, "Tom"},
            { 3, "Sam"},
            { 11, "Bob"}
        };
        
        ToLog(people);
    }

    public void ToLog(Dictionary<int, string> dd)
    {
        Debug.Log(dd);
    }
   
}
