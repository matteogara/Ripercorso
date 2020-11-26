using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject map;
    public GameObject mapWhisper;
    public GameObject mapSpark;
    public GameObject popVenues;
    public GameObject listenStart;
    public GameObject listen;
    public GameObject listenPause;
    public GameObject recordStart;
    public GameObject recordStartFromSpark;
    public GameObject record;
    public GameObject recordPaused;
    public GameObject recordFinished;
    public GameObject delete;
    public GameObject share;

    GameObject currentPage;



    private void Start()
    {
        ChangePage(map);
    }

    public void ButtonLPressed()
    {
        if (currentPage == map)
        {
            ChangePage(popVenues);
        } 
        else if (currentPage == mapWhisper)
        {
            //aaa
        }
        else if (currentPage == mapSpark)
        {
            //aaa
        } 
        else if (currentPage == popVenues)
        {
            //aaa
        } 
        else if (currentPage == listenStart)
        {
            //aaa
        } 
        else if (currentPage == listen)
        {
            //aaa
        } 
        else if (currentPage == listenPause)
        {
            //aaa
        } 
        else if (currentPage == recordStart)
        {
            //aaa
        } 
        else if (currentPage == recordStartFromSpark)
        {
            //aaa
        } 
        else if (currentPage == record)
        {
            //aaa
        } 
        else if (currentPage == recordPaused)
        {
            //aaa
        } 
        else if (currentPage == recordFinished)
        {
            //aaa
        } 
        else if (currentPage == delete)
        {
            //aaa
        } 
        else if (currentPage == share)
        {
            //aaa
        } else
        {
            Debug.Log("Error");
        }
    }


    public void ButtonRPressed()
    {
        if (currentPage == map)
        {
            //aaa
        }
        else if (currentPage == mapWhisper)
        {
            //aaa
        }
        else if (currentPage == mapSpark)
        {
            //aaa
        }
        else if (currentPage == popVenues)
        {
            //aaa
        }
        else if (currentPage == listenStart)
        {
            //aaa
        }
        else if (currentPage == listen)
        {
            //aaa
        }
        else if (currentPage == listenPause)
        {
            //aaa
        }
        else if (currentPage == recordStart)
        {
            //aaa
        }
        else if (currentPage == recordStartFromSpark)
        {
            //aaa
        }
        else if (currentPage == record)
        {
            //aaa
        }
        else if (currentPage == recordPaused)
        {
            //aaa
        }
        else if (currentPage == recordFinished)
        {
            //aaa
        }
        else if (currentPage == delete)
        {
            //aaa
        }
        else if (currentPage == share)
        {
            //aaa
        }
    }


    public void ChangePage(GameObject _newPage)
    {
        Debug.Log("Changing page to: " + _newPage.name);

        if (currentPage) Destroy(currentPage);

        currentPage = Instantiate(_newPage, transform.position, transform.rotation);
        currentPage.transform.parent = transform;
        currentPage.transform.localScale = Vector3.one * .00005f;
    }
}
