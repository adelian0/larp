using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    public float boundary;
    public GameObject bg;

    // Update is called once per frame
    void Update()
    {
        if(bg.transform.position.x >= boundary) {
            GameObject old = bg;
            bg = Instantiate(bg);
        }
    }

    
}
