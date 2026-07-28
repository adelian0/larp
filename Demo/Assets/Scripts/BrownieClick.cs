using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrownieClick : MonoBehaviour
{
    public int Cookiecounter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnMouseDown()
    {
        Cookiecounter += 1;
        Debug.Log(Cookiecounter);
    }
}
