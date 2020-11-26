using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hand : MonoBehaviour
{
    public Book book;
    public WalkAround walkAround;
    public float verticalOffset = 0.1f;
    public float smooth = 0.04f;

    Transform handObject;
    Vector3 handInitPos;
    float x;


    void Start()
    {
        handObject = transform.GetChild(0);
        handInitPos = handObject.transform.localPosition;
    }

    void Update()
    {
        // Hide / show hand
        if (book.isOpen && book.isCompletelyOpen && !walkAround.bookPartiallyHidden) // hand follows cursor
        {
            x = Mathf.Lerp(x, 0, smooth);
        } else // hand goes down
        {
            x = Mathf.Lerp(x, verticalOffset, smooth);
        }
        handObject.transform.localPosition = handInitPos + Vector3.up * x;

        // Update pointer position
        RaycastHit hit;
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out hit, 0.35f))
        {
            transform.position = hit.point;

            // If hovering on button and click
            GameObject hitObject = hit.collider.gameObject;
            if (hitObject.tag == "Button" && Input.GetMouseButtonDown(0))
            {
                hitObject.GetComponent<PushButton>().TriggerAnimation();
            }
        }
    }
}
