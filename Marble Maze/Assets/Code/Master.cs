using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    // Startup values
    bool alive = true;
    int current_level = 1;


    // Start is called before the first frame update
    void Start()
    {
        //test
        print("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        //Movement



        if (!alive)
        {
            Reset(current_level);
        }
    }

    void Reset(int level)
    {
        
    }
}
