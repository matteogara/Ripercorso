using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshPro textMesh;

    int time;



    void StartTimer() {
        StartCoroutine(UpdateTimer());
    }


    void PauseTimer() {
        StopAllCoroutines();
    }


    void StopTimer() {
        StopAllCoroutines();
        time = 0;
        textMesh.text = "0:00";
    }


    IEnumerator UpdateTimer() {
        yield return new WaitForSeconds(1);

        time++;
        string mins = Mathf.Floor(time / 60).ToString();
        string secs = (time % 60).ToString("00");
        textMesh.text = mins + ":" + secs;

        StartCoroutine(UpdateTimer());
    }
}
