using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    // public int[] number;

    public int Index = 3;
    private int A    = 2;
    private int B    = 1;


    void Start()
    {
        if (Index >A && Index >  B) //  참이라면 
        {
            Debug.Log("true");
        }
       else
        {
            Debug.Log("false");
        }
    }
    void Update()
    {
      /*  int index = Random.Range(2, number.Length);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("index" + index);
        }*/

       
    }
}
