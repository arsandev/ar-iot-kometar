using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;
using System;
using System.Net;

public class vbScriptOn : MonoBehaviour, IVirtualButtonEventHandler
{

    public GameObject vbButtonObjectOn;
    public GameObject vbButtonObjectOff;

    // Use this for initialization
    void Start()
    {
        vbButtonObjectOn = GameObject.Find("buttonOn");
        vbButtonObjectOn.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);

        vbButtonObjectOff = GameObject.Find("buttonOff");
        vbButtonObjectOff.GetComponent<VirtualButtonBehaviour>().RegisterEventHandler(this);
    }

    public void OnButtonPressed( VirtualButtonBehaviour vb )
    {
        //Debug.Log("pressed");
        if(vb.name == "buttonOn")
        {
            new WebClient().DownloadString("http://ttg.yoviews.com/?status=1");
            Debug.Log("nyala");
        }
        else
        {
            new WebClient().DownloadString("http://ttg.yoviews.com/?status=0");
            Debug.Log("mati");
        }
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        
    }
}