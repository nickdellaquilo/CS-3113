using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Master : MonoBehaviour
{

    // Startup values
    bool alive = true;
    public int current_level = 1;


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
