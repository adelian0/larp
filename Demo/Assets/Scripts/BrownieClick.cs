using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BrownieClick : MonoBehaviour
{
    public TMP_Text VisualCounter;
    public Animator Animator;
    public int Cookiecounter;
    public AudioSource ClickSound;

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
        ClickSound.Play();
        Cookiecounter += 1;
        Debug.Log(Cookiecounter);
        Animator.SetTrigger("Clicked");
        VisualCounter.text = Cookiecounter.ToString();
    } 
}
