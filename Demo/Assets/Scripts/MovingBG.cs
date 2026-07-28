using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBG : MonoBehaviour
{ 
    public float speed;
    public float boundary;
    public GameObject bg;
    private Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(speed, 0, 0));

        if(gameObject.transform.position.x >= boundary) {
            Instantiate(bg, startingPos, Quaternion.identity);
            Debug.Log("Called");
            Destroy(gameObject);
        }
    }
}
