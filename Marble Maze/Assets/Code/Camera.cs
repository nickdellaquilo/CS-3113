using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{

    private Quaternion set_rotation;

    public Transform playerTrans;

    Vector3 offSet;

    // Start is called before the first frame update
    void Start()
    {
        set_rotation = this.transform.rotation;

        offSet = transform.position - playerTrans.position;

    }

    // Update is called once per frame
    void Update()
    {
        this.transform.rotation = set_rotation;

        transform.position = playerTrans.position + offSet;
    }
}
