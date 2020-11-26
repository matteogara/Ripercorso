using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkAround : MonoBehaviour
{
    [Header("Player")]
    public float speed = 5;
    public float sensitivity = 5;
    public float smoothing = 2;
    public Transform cam;
    [Header("Book")]
    public Transform bookPivot;
    public Book book;
    public float bookLowAngle = 30;
    public float bookHighAngle = 70;

    [HideInInspector]
    public bool bookPartiallyHidden;

    Vector2 mouseLook;
    Vector2 smoothV;


    void Start()
    {
    }

    void FixedUpdate()
    {
        // Translation
        Vector3 input = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        input = input.normalized;
        Vector3 velocity = (transform.right * input.x + transform.forward * input.z) * speed;
        transform.position += velocity * Time.deltaTime;

        // Rotation
        var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));
        md = Vector2.Scale(md, new Vector2(sensitivity * smoothing, sensitivity * smoothing));
        smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        smoothV.y = Mathf.Lerp(smoothV.y, md.y, 1f / smoothing);
        smoothV.x = (!bookPartiallyHidden && book.isCompletelyOpen) ? smoothV.x / 4 : smoothV.x;
        mouseLook += smoothV;
        mouseLook.y = Mathf.Clamp(mouseLook.y, -90f, 90f);
        cam.transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        transform.localRotation = Quaternion.AngleAxis(mouseLook.x, transform.up);

        // Book pivot rotation
        float progress = Map(Mathf.PI/2, -Mathf.PI/2, bookLowAngle, bookHighAngle, -mouseLook.y);
        float bookRotY = (Mathf.Sin(progress) + 1) * 15;
        bookPivot.transform.localRotation = Quaternion.AngleAxis(bookRotY, Vector3.right);

        // Check if bookk is fully visible (for other scripts)
        bookPartiallyHidden = bookRotY > 16;
    }


    float Map(float _from, float _to, float _from2, float _to2, float _value)
    {
        if (_value <= _from2)
            return _from;
        else if (_value >= _to2)
            return _to;
        return (_to - _from) * ((_value - _from2) / (_to2 - _from2)) + _from;
    }
}
