using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        int[] points = { 30, 20, 50, 10, 80, 15, 60, 100 };
        int[] array = { 15, 20, 45, 25, 10 };
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int i = 4; i >= 0; i--)
        {
            Debug.Log(array[i]);
        }
        for (int i = 0; i < points.Length; i++)
        {

            if (points[i] >= 50)

            {
               // Debug.Log(points[i]);
            }
        }
    }
        // Update is called once per frame
        void Update()
        {

        }
}
    