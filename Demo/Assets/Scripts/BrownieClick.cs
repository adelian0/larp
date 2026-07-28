using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BrownieClick : MonoBehaviour
{
    public TMP_Text VisualCounter;
    public Animator Animator;
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
        Animator.SetTrigger("Clicked");
        VisualCounter.text = Cookiecounter.ToString();
    } 
}
