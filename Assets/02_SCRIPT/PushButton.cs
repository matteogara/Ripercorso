using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    public enum ButtonType {Left, Right}
    public ButtonType buttonType;
    public Animator bookAnim;

    AudioSource audio;
    UIManager uiManager;


    private void Start()
    {
        audio = GetComponent<AudioSource>();
        uiManager = GameObject.Find("MANAGER").GetComponent<UIManager>();
    }


    public void TriggerAnimation()
    {
        if (buttonType == ButtonType.Left)
        {
            bookAnim.SetTrigger("PushL");
            uiManager.ButtonLPressed();
        } else if (buttonType == ButtonType.Right)
        {
            bookAnim.SetTrigger("PushR");
            uiManager.ButtonRPressed();
        }

        audio.Play();
    }
}
