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
        if (currentPage.tag == map.tag)
        {
            ChangePage(popVenues);
        } 
        else if (currentPage.tag == mapWhisper.tag)
        {
            ChangePage(map);
        }
        else if (currentPage.tag == mapSpark.tag)
        {
            ChangePage(map);
        } 
        else if (currentPage.tag == popVenues.tag)
        {
            ChangePage(map);
        } 
        else if (currentPage.tag == listenStart.tag)
        {
            ChangePage(map);
        } 
        else if (currentPage.tag == listen.tag)
        {
            ChangePage(map);
        } 
        else if (currentPage.tag == listenPause.tag)
        {
            ChangePage(map);
        } 
        else if (currentPage.tag == recordStart.tag)
        {
            ChangePage(map);
        } 
        else if (currentPage.tag == recordStartFromSpark.tag)
        {
            ChangePage(map);
        } 
        else if (currentPage.tag == record.tag)
        {
            ChangePage(recordFinished);
        } 
        else if (currentPage.tag == recordPaused.tag)
        {
            ChangePage(recordFinished);
        } 
        else if (currentPage.tag == recordFinished.tag)
        {
            ChangePage(delete);
        } 
        else if (currentPage.tag == delete.tag)
        {
            ChangePage(recordFinished);
        } 
        else if (currentPage.tag == share.tag)
        {
            ChangePage(recordFinished);
        } else
        {
            Debug.Log("Error");
        }
    }


    public void ButtonRPressed()
    {
        if (currentPage.tag == map.tag)
        {
            ChangePage(recordStart);
        }
        else if (currentPage.tag == mapWhisper.tag)
        {
            ChangePage(listenStart);
        }
        else if (currentPage.tag == mapSpark.tag)
        {
            ChangePage(recordStartFromSpark);
        }
        else if (currentPage.tag == popVenues.tag)
        {
            ChangePage(recordStart);
        }
        else if (currentPage.tag == listenStart.tag)
        {
            ChangePage(listen);
        }
        else if (currentPage.tag == listen.tag)
        {
            ChangePage(listenPause);
        }
        else if (currentPage.tag == listenPause.tag)
        {
            ChangePage(listen);
        }
        else if (currentPage.tag == recordStart.tag)
        {
            ChangePage(record);
        }
        else if (currentPage.tag == recordStartFromSpark.tag)
        {
            ChangePage(record);
        }
        else if (currentPage.tag == record.tag)
        {
            ChangePage(recordPaused);
        }
        else if (currentPage.tag == recordPaused.tag)
        {
            ChangePage(record);
        }
        else if (currentPage.tag == recordFinished.tag)
        {
            ChangePage(share);
        }
        else if (currentPage.tag == delete.tag)
        {
            ChangePage(map);
        }
        else if (currentPage.tag == share.tag)
        {
            ChangePage(map);
        }
        else
        {
            Debug.Log("Error");
        }
    }


    public void ChangePage(GameObject _newPage)
    {
        Debug.Log("Changing page to: " + _newPage.name);

        if (currentPage) Destroy(currentPage);

        if (_newPage)
        {
            currentPage = Instantiate(_newPage, transform.position, transform.rotation);
            currentPage.transform.parent = transform;
            currentPage.transform.localScale = Vector3.one * .00005f;
        }
    }
}
