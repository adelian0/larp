using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBG : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(.001f, 0, 0));
    }
}
