using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
    public enum ButtonType {Left, Right}
    public ButtonType buttonType;
    public Animator bookAnim;
    public UIManager uiManager;

    AudioSource audio;


    private void Start()
    {
        audio = GetComponent<AudioSource>();
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
