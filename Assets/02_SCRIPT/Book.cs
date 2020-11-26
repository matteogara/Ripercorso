using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book : MonoBehaviour
{
    [HideInInspector]
    public bool isOpen;
    public bool isCompletelyOpen;

    Animator anim;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            isOpen = !isOpen;
            anim.SetBool("Open", isOpen);
            StartCoroutine(FinishOpenClose(isOpen));
        }

    }


    IEnumerator FinishOpenClose(bool _value)
    {
        // wait for the same length of the opening / closing animation
        yield return new WaitForSeconds(1);

        isCompletelyOpen = _value;
    }
}
