using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpdateText : MonoBehaviour
{
    TextMeshPro textMesh;


    void Start()
    {
        textMesh = GetComponent<TextMeshPro>();
    }


    public void OnInterimResults(string youSaid)
    {
        textMesh.text = youSaid;
    }


    public void OnFinalResult(string youSaid)
    {
        textMesh.text = youSaid;
    }
}
